using UnityEngine;

public class Enemy : MonoBehaviour
{
	public Transform EndPoint;

	public AnimationCurve animationCurve;

	public float animationSpeed;

	public float startTime;

	private Vector2 startPoint;

	private Vector2 endPoint;

	private float animTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void resetState()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
