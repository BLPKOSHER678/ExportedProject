using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
	public class TFGScreenTouch
	{
		public _Touch touch;

		public TFGScreenTouch(Touch touch)
		{
	
            this.touch = new _Touch(touch);
		}

		public TFGScreenTouch(_Touch touch)
		{
	
            this.touch = touch;
		}
	}

	public struct TFGTouch
	{
		public _Touch touch;

		public Vector3 worldPosition;

		public Vector2 relativeDeltaPosition;

		public float distance;

		public TFGTouch(Touch touch, RaycastHit hitInfo)
		{
	
            this.touch = new _Touch(touch);
            worldPosition = hitInfo.point;
            relativeDeltaPosition = touch.deltaPosition;
            distance = hitInfo.distance;
		}

		public TFGTouch(_Touch touch, RaycastHit hitInfo)
		{
	
            this.touch = touch;
            worldPosition = hitInfo.point;
            relativeDeltaPosition = touch.deltaPosition;
            distance = hitInfo.distance;
		}
	}

	public struct _Touch
	{
		public int fingerId;

		public Vector2 position;

		public Vector2 deltaPosition;

		public float deltaTime;

		public int tapCount;

		public TouchPhase phase;

		public _Touch(int id, Vector2 pos, Vector2 dpos, float dt, int tc, TouchPhase ph)
		{
	
            fingerId = id;
            position = pos;
            deltaPosition = dpos;
            deltaTime = dt;
            tapCount = tc;
            phase = ph;
		}

		public _Touch(Touch t)
		{
	
            fingerId = t.fingerId;
            position = t.position;
            deltaPosition = t.deltaPosition;
            deltaTime = t.deltaTime;
            tapCount = t.tapCount;
            phase = t.phase;
		}
	}

	public Camera targetCamera;

	public float maxDistance;

	public LayerMask layerMask;

	public LayerMask layerMaskPopup;

	private Dictionary<int, GameObject> touchToObject;

	private Touch[] touches;

	private Touch[] oldTouches;

	private static TouchManager _instance;

	public int touchCount;

	private Vector2 previousMousePosition;

	private Vector2 deltaMousePosition;

	private float deltaMouseTime;

	private int mouseTapCount;

	private TouchPhase mousePhase;

	private float mouseTapTime;

	private Vector2 mouseTapPosition;

	private string newInput;

	private string newInputOld;

	private string debugMsg;

	public bool showDebug;

	public bool showDebug2;

	public static TouchManager instance
	{
		get
		{
			return default;
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public bool isTouchOff(TFGTouch touch)
	{
		return default;
	}

	public bool anyTouch()
	{
		return default;
	}

	public Vector2 getTouchPosition(int fingerID)
	{
		return default;
	}

	public Vector2 getTouchDelta(int fingerID)
	{
		return default;
	}

	public TFGScreenTouch getTouch(int fingerID)
	{
		return default;
	}

	public Vector2 getTouchRelativeDelta(int fingerID)
	{
		return default;
	}

	public _Touch[] GenerateTouchList()
	{
		return default;
	}
}
