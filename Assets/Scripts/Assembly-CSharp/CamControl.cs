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
        viewportOffset = offset;
	}

	private void Start()
	{
        init();
	}

	public void init()
	{
        if (target != null) targetRigidbody = target.GetComponent<Rigidbody>();
        if (target != null) resetCam();
	}

	public void resetCam()
	{
        died = false;
        finished = false;
        if (target != null)
            transform.position = target.position + camOffset + viewportOffset;
        camSpeed = Vector3.zero;
	}

	private void findHotSpots()
	{
        hotSpots = FindObjectsOfType<CamHotSpot>();
	}

	private CamHotSpot getAffectingHotSpot()
	{
		return null;
	}

	private void FixedUpdate()
	{
        if (target == null) return;
        Vector3 intended = target.position + camOffset + viewportOffset;
        if (targetRigidbody == null) targetRigidbody = target.GetComponent<Rigidbody>();
        if (targetRigidbody != null && !died && !finished)
        {
            intended.x += Mathf.Clamp(targetRigidbody.velocity.x * forwardFactor.x, -forwardThreshold, forwardThreshold);
            intended.y += Mathf.Clamp(targetRigidbody.velocity.y * forwardFactor.y, -forwardThreshold, forwardThreshold);
        }
        float duration = Mathf.Max(0.02f, 1f / Mathf.Max(0.2f, moveSpeed.x));
        if (finished) duration = Mathf.Max(0.02f, 1f / Mathf.Max(0.2f, endSmooth));
        transform.position = Vector3.SmoothDamp(transform.position, intended, ref camSpeed, duration);
	}

	public void LevelFinished()
	{
        finished = true;
	}

	public void PlayerDied()
	{
        died = true;
	}
}
