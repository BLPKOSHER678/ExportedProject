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
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
