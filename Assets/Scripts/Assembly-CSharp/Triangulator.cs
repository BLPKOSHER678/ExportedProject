using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class Triangulator : MonoBehaviour
{
	private const float EPSILON = 1E-10f;

	public Vector2[] points;

	public Vector2 uvTiling;

	public Vector2 uvOffset;

	private Mesh mesh;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void generate()
	{
	}

	public static float Area(Vector2[] contour)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool InsideTriangle(float Ax, float Ay, float Bx, float By, float Cx, float Cy, float Px, float Py)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool Snip(Vector2[] contour, int u, int v, int w, int n, int[] V)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static int[] Process(Vector2[] contour)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void Test()
	{
	}
}
