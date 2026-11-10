using UnityEngine;

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

	private void Start()
	{
	}

	private void refreshWeights()
	{
	}

	private Mesh applyScale()
	{
		return default;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
