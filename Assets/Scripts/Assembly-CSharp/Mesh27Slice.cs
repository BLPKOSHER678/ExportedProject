using UnityEngine;

/// <summary>
/// Recreates the rendered island mesh from the retained source Mesh asset.
/// Approximate scaling only; original 27-slice deformation code was stripped.
/// </summary>
[ExecuteInEditMode]
public class Mesh27Slice : MonoBehaviour
{
    public bool refreshModel;
    public float uniformScale;
    public Vector3 meshScale;
    public Vector3 sliceMin;
    public Vector3 sliceMax;
    private Bounds bounds;
    public float boundsExtra;
    public Mesh originalMesh;
    private Vector3[] vertWeights;
    public bool autoAdjustCollider;
    public bool showSlices;
    public bool debug;
    private MeshFilter meshFilter;
    private Mesh generated;

    private void OnEnable() { Start(); }

    private void Start()
    {
        if (meshFilter == null) meshFilter = GetComponent<MeshFilter>();
        if (meshFilter == null || originalMesh == null) return;
        if (generated == null || refreshModel) applyScale();
    }

    private void refreshWeights()
    {
        if (originalMesh == null) return;
        vertWeights = originalMesh.vertices;
    }

    private Mesh applyScale()
    {
        if (originalMesh == null) return null;
        if (meshFilter == null) meshFilter = GetComponent<MeshFilter>();
        if (meshFilter == null) return null;

        float uniform = Mathf.Abs(uniformScale) < 0.001f ? 1f : uniformScale;
        Vector3 extraScale = meshScale;
        if (extraScale == Vector3.zero) extraScale = Vector3.one;
        Mesh candidate = Instantiate(originalMesh);
        candidate.name = name + "_restored_27slice";
        Vector3[] array = candidate.vertices;
        for (int i = 0; i < array.Length; i++)
            array[i] = Vector3.Scale(array[i], extraScale) * uniform;
        candidate.vertices = array;
        candidate.RecalculateBounds();
        candidate.RecalculateNormals();

        Mesh oldMesh = generated;
        generated = candidate;
        bounds = candidate.bounds;
        meshFilter.sharedMesh = candidate;
        // Preserve original BoxCollider positions and sizes from the level scenes.
        if (oldMesh != null && oldMesh != candidate)
        {
            if (Application.isPlaying) Destroy(oldMesh);
            else DestroyImmediate(oldMesh);
        }
        return candidate;
    }

    private void OnDrawGizmosSelected()
    {
        if (!showSlices) return;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.TransformPoint(bounds.center),
            Vector3.Scale(bounds.size, transform.lossyScale));
    }
}
