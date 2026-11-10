using UnityEngine;

public class Cannon : MonoBehaviour
{
	private Rigidbody player;

	public float shootSpeed;

	public bool returnAfterFire;

	public bool translate;

	public bool alwaysTranslate;

	public bool setRotation;

	public Transform endPoint;

	public Transform axis;

	public Transform pivot;

	public float moveSpeed;

	public AnimationCurve translationCurve;

	private float translationTime;

	private Vector3 startPosition;

	public bool rotate;

	public float rotationA;

	public float rotationB;

	public float rotationSpeed;

	public float rotationAccel;

	public float rotationDampP;

	public float rotationDampV;

	private float targetRotation;

	private float startRotation;

	private float rotationAngle;

	private float rotationInstantSpeed;

	public float rotationThreshold;

	private bool goingBack;

	public float cannonDelayTime;

	private float enterDelay;

	public AudioClip enterSound;

	public AudioClip shootSound;

	private bool toReEnable;

	private void Start()
	{
	}

	public void resetState()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Fire()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
