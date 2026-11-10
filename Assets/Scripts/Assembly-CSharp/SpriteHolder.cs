using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class SpriteHolder : MonoBehaviour
{
	public Sprite sprite;

	public Vector2 meshScale;

	public Vector3[] verts;

	public Vector2[] uvs;

	private Mesh mesh;

	public Mesh spriteMesh
	{
		get
		{
			return default;
		}
	}

	private void Start()
	{
	}

	public void createMesh()
	{
	}

	public void Update()
	{
	}
}
