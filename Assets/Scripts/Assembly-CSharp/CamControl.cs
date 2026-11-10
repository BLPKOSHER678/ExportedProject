using UnityEngine;

public class CamControl : MonoBehaviour
{
	public Transform target;

	public Vector3 camOffset;

	public Vector2 moveSpeed;

	public float speedZoom;

	public float speedZoomSpeed;

	public Vector2 forwardFactor;

	public Vector2 forwardSmoothness;

	private Vector2 forwardOffset;

	public float forwardThreshold;

	private Rigidbody targetRigidbody;

	private bool died;

	private Vector3 camSpeed;

	public float endSmooth;

	public float hotSpotSmoothness;

	public float hotSpotZoom;

	public float hotSpotWeight;

	private CamHotSpot[] hotSpots;

	public Vector3 endingPosition;

	public float endingAccel;

	private Vector3 endingTarget;

	private bool finished;

	private Vector3 targetOldPosition;

	public Vector3 viewportOffset;

	public AnimationCurve hotspotWeightCurve;

	public void SetPerspectiveOffset(Vector3 offset)
	{
	}

	private void Start()
	{
	}

	public void init()
	{
	}

	public void resetCam()
	{
	}

	private void findHotSpots()
	{
	}

	private CamHotSpot getAffectingHotSpot()
	{
		return default;
	}

	private void FixedUpdate()
	{
	}

	public void LevelFinished()
	{
	}

	public void PlayerDied()
	{
	}
}
