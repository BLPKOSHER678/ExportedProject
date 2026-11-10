using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
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

	private void Start()
	{
	}

	public Mesh updateMesh()
	{
		return default;
	}

	private void generateCollider(Mesh mesh)
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void generateStrip(int vertStart, int faceStart, float Z1, float Z2, float inset1, float inset2, float normalRotation1, float normalRotation2, float startUV, float endUV, float uvTiling, bool cut)
	{
	}

	private void generateStrip2(int vertStart, int faceStart, float Z1, float Z2, float inset1, float inset2, float normalRotation1, float normalRotation2, float startUV, float endUV, float uvTiling)
	{
	}
}
