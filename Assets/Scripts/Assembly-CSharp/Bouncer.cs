using UnityEngine;

public class Bouncer : MonoBehaviour
{
	public bool limitMinForce;

	public bool setForce;

	public float minForce;

	public float forceMultiplier;

	public bool setDirection;

	public Vector2 newDirection;

	public AudioClip bounceClip;

	private void OnCollisionEnter(Collision collisionInfo)
	{
	}
}
