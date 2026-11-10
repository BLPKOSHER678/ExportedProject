using UnityEngine;

public class MapControl : MonoBehaviour
{
	private float touchDistanceOld;

	public float maxOutScale;

	public float zoomOutScale;

	public float zoomInScale;

	private float zoom;

	public float zoomAdjustSpeed;

	private float targetZoom;

	public float moveFriction;

	private Vector2 moveSpeed;

	private bool autoZoom;

	private bool autoMove;

	private float startZoom;

	private Vector2 screenMiddle;

	private Vector2 middlePoint;

	private bool toSetPosition;

	private Vector2 positionToBeSet;

	private float setPositionTimer;

	public float setPositionTime;

	public Transform mapBG;

	private float aspect;

	private float screenWidth;

	private float screenHeight;

	private float touchSpeedAdjust;

	public bool blockNavigation;

	private void Start()
	{
	}

	public void setPosition(Vector2 position)
	{
	}

	private void Update()
	{
	}
}
