using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Spline : MonoBehaviour
{
	public Vector3[] controlPoints;

	public float width;

	public float step;

	private List<Vector3> points;

	public float controlSize;

	public float pointSize;

	public Vector3 normalDirection;

	private Vector3[] vertices;

	private Vector4[] tangents;

	private Vector2[] uvs;

	private int[] triangles;

	private Mesh mesh;

	public bool showPoints;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void CalculateSplinePoints()
	{
	}

	private void GenerateGeometry()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
