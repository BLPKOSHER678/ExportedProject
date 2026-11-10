using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
	public class TFGScreenTouch
	{
		public _Touch touch;

		public TFGScreenTouch(Touch touch)
		{
		}

		public TFGScreenTouch(_Touch touch)
		{
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
		}

		public TFGTouch(_Touch touch, RaycastHit hitInfo)
		{
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
		}

		public _Touch(Touch t)
		{
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
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool anyTouch()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Vector2 getTouchPosition(int fingerID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Vector2 getTouchDelta(int fingerID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public TFGScreenTouch getTouch(int fingerID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Vector2 getTouchRelativeDelta(int fingerID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public _Touch[] GenerateTouchList()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
