using UnityEngine;

public class RandomRotator : MonoBehaviour
{
	public Vector3 localAxis;

	public float speedRange;

	public float nextChangeRange;

	public float smoothness;

	private float nextChangeTimer;

	private float currentSpeed;

	private float targetSpeed;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
