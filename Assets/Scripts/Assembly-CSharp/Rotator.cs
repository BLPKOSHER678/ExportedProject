using UnityEngine;

public class Rotator : MonoBehaviour
{
	public float speed;

	public bool rotate;

	public Vector3 axis;

	public bool oscilateScale;

	public float minScale;

	public float maxScale;

	public float scaleOscSpeed;

	private float oscTime;

	public bool useAbsoluteTime;

	private float lastTime;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
