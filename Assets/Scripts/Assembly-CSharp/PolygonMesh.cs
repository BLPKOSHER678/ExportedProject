using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Reconstructs a simple extruded polygon from the original serialized outline.
/// The original Mesh27Slice/PolygonMesh implementations were stripped; this
/// approximation preserves serialized fields and restores visible/collidable terrain.
/// </summary>
[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class PolygonMesh : MonoBehaviour
{
    public Vector2[] points;
    public bool[] isBack;
    public float width;
    private Mesh mesh;
    private Mesh colliderMesh;
    private Vector3[] vertices;
    private Vector3[] normals;
    private Vector2[] uvs;
    private Color[] colors;
    private int[] triangles;
    private int[] closingTriangles;
    public Vector2 mainTiling;
    public float mainTilingBack;
    public float mainOffset;
    public bool bevel;
    public float bevelSize;
    public bool border;
    public float borderSize;
    public float borderTiling;
    public bool closed;
    public Vector2 closingTiling;
    public Vector2 closingOffset;
    public float colliderWidth;
    public bool showDebug;
    public float tipOffset;

    private void OnEnable() { if (points != null && points.Length >= 3) updateMesh(); }
    private void Start() { if (mesh == null && points != null && points.Length >= 3) updateMesh(); }

    public Mesh updateMesh()
    {
        if (points == null || points.Length < 3) return null;
        MeshFilter filter = GetComponent<MeshFilter>();
        if (filter == null) return null;
        int n = points.Length;
        float depth = Mathf.Max(0.2f, Mathf.Abs(width));
        float half = depth * 0.5f;
        List<Vector3> v = new List<Vector3>(n * 2);
        List<Vector2> uv = new List<Vector2>(n * 2);
        float tileX = Mathf.Abs(mainTiling.x) > 0.0001f ? mainTiling.x : 0.1f;
        float tileY = Mathf.Abs(mainTiling.y) > 0.0001f ? mainTiling.y : 0.1f;
        for (int side = 0; side < 2; side++)
        {
            for (int i = 0; i < n; i++)
            {
                Vector2 p = points[i];
                v.Add(new Vector3(p.x, p.y, side == 0 ? -half : half));
                uv.Add(new Vector2((p.x + mainOffset) * tileX, p.y * tileY));
            }
        }

        List<int> caps = new List<int>();
        List<int> boundary = new List<int>();
        List<int> polygon = new List<int>();
        float winding = 0f;
        for (int i = 0; i < n; i++)
        {
            Vector2 a = points[i];
            Vector2 b = points[(i + 1) % n];
            winding += a.x * b.y - b.x * a.y;
        }
        bool ccw = winding >= 0f;
        for (int i = 0; i < n; i++) polygon.Add(ccw ? i : n - 1 - i);

        int guard = n * n;
        while (polygon.Count > 3 && guard-- > 0)
        {
            bool cutEar = false;
            for (int i = 0; i < polygon.Count; i++)
            {
                int a = polygon[(i + polygon.Count - 1) % polygon.Count];
                int b = polygon[i];
                int c = polygon[(i + 1) % polygon.Count];
                if (Cross(points[b] - points[a], points[c] - points[b]) <= 0.00001f) continue;
                bool occupied = false;
                for (int j = 0; j < polygon.Count; j++)
                {
                    int candidate = polygon[j];
                    if (candidate == a || candidate == b || candidate == c) continue;
                    if (InsideTriangle(points[candidate], points[a], points[b], points[c]))
                    {
                        occupied = true;
                        break;
                    }
                }
                if (occupied) continue;
                AddCap(caps, a, b, c, n);
                polygon.RemoveAt(i);
                cutEar = true;
                break;
            }
            if (!cutEar) break;
        }
        if (polygon.Count == 3) AddCap(caps, polygon[0], polygon[1], polygon[2], n);
        if (caps.Count == 0)
        {
            Debug.LogWarning("Jelly Jump polygon could not be triangulated: " + name, this);
            return null;
        }

        for (int i = 0; i < n; i++)
        {
            int a = i, b = (i + 1) % n;
            if (ccw)
            {
                boundary.Add(a); boundary.Add(b); boundary.Add(b + n);
                boundary.Add(a); boundary.Add(b + n); boundary.Add(a + n);
            }
            else
            {
                boundary.Add(a); boundary.Add(b + n); boundary.Add(b);
                boundary.Add(a); boundary.Add(a + n); boundary.Add(b + n);
            }
        }

        Mesh built = new Mesh { name = name + "_restored_polygon" };
        if (v.Count > 65535) built.indexFormat = UnityEngine.Rendering.IndexFormat.UInt32;
        built.SetVertices(v);
        built.SetUVs(0, uv);
        built.subMeshCount = 2;
        built.SetTriangles(caps, 0);
        built.SetTriangles(boundary, 1);
        built.RecalculateNormals();
        built.RecalculateBounds();
        Mesh previous = mesh;
        mesh = built;
        vertices = built.vertices;
        normals = built.normals;
        uvs = built.uv;
        triangles = caps.ToArray();
        closingTriangles = boundary.ToArray();
        filter.sharedMesh = built;

        MeshCollider meshCollider = GetComponent<MeshCollider>();
        if (meshCollider == null) meshCollider = gameObject.AddComponent<MeshCollider>();
        meshCollider.sharedMesh = null;
        meshCollider.convex = false;
        meshCollider.sharedMesh = built;
        colliderMesh = built;

        if (previous != null && previous != built)
        {
            if (Application.isPlaying) Destroy(previous);
            else DestroyImmediate(previous);
        }
        return built;
    }

    private static float Cross(Vector2 a, Vector2 b) { return a.x * b.y - a.y * b.x; }

    private static bool InsideTriangle(Vector2 p, Vector2 a, Vector2 b, Vector2 c)
    {
        const float e = -0.00001f;
        return Cross(b - a, p - a) >= e &&
               Cross(c - b, p - b) >= e &&
               Cross(a - c, p - c) >= e;
    }

    private static void AddCap(List<int> result, int a, int b, int c, int n)
    {
        // The front surface faces towards -Z; the rear faces +Z.
        result.Add(c); result.Add(b); result.Add(a);
        result.Add(a + n); result.Add(b + n); result.Add(c + n);
    }

    private void generateCollider(Mesh source)
    {
        MeshCollider collider = GetComponent<MeshCollider>();
        if (collider == null) collider = gameObject.AddComponent<MeshCollider>();
        collider.sharedMesh = null;
        collider.sharedMesh = source;
        colliderMesh = source;
    }

    private void OnDrawGizmos()
    {
        if (!showDebug || points == null || points.Length < 2) return;
        Gizmos.color = Color.green;
        for (int i = 0; i < points.Length; i++)
        {
            Vector2 p = points[i];
            Vector2 q = points[(i + 1) % points.Length];
            Gizmos.DrawLine(transform.TransformPoint(p), transform.TransformPoint(q));
        }
    }

    // Preserved signatures because recovered component metadata may refer to them.
    private void generateStrip(int vertStart, int faceStart, float Z1, float Z2,
        float inset1, float inset2, float normalRotation1, float normalRotation2,
        float startUV, float endUV, float uvTiling, bool cut) { }
    private void generateStrip2(int vertStart, int faceStart, float Z1, float Z2,
        float inset1, float inset2, float normalRotation1, float normalRotation2,
        float startUV, float endUV, float uvTiling) { }
}
