using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TFGButton : MonoBehaviour
{
	[Serializable]
	public class Action
	{
		public enum ActionType
		{
			open = 0,
			close = 1,
			changeWindow = 2,
			quitGame = 3,
			startTransition = 4,
			startAnimation = 5,
			stopAnimation = 6,
			loadScene = 7,
			loadSceneAdditive = 8,
			customAction = 9
		}

		public enum TypeEvent
		{
			OnBegin = 0,
			OnHold = 1,
			OnDrag = 2,
			OnLeave = 3,
			OnEnter = 4,
			OnEnd = 5,
			OnEndStill = 6,
			OnActivate = 7,
			OnDeactivate = 8
		}

		public delegate void TargetMethodFormat(string param);

		public TypeEvent typeEvent;

		public ActionType actionType;

		public GameObject target;

		public string parameter;

		public string customMethod;

		public TargetMethodFormat targetMethod;

		public float delay;

		public Action()
		{
		}

		public Action(string customMethod, GameObject target, TypeEvent typeEvent = TypeEvent.OnEnd)
		{
		}

		public Action(string customMethod, string param, GameObject target, TypeEvent typeEvent = TypeEvent.OnEnd)
		{
		}

		public void execute()
		{
		}

		[DebuggerHidden]
		private IEnumerator executeDelayed()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private void efetiveExecute()
		{
		}
	}

	public List<Action> actions;

	private List<Action> onTouchBeginActions;

	private List<Action> onTouchEndedActions;

	private List<Action> onTouchMovedActions;

	private List<Action> onTouchStillActions;

	private List<Action> onTouchEnteredActions;

	private List<Action> onTouchLeaveActions;

	private List<Action> onTouchEndedStillActions;

	private List<Action> onActivateActions;

	private List<Action> onDeactivateActions;

	private TFGTouchScroll scroll;

	private bool grayed;

	public GameObject idleState;

	public GameObject pressedState;

	public GameObject activeState;

	public GameObject grayedState;

	private GameObject currentState;

	public bool toggleable;

	public bool activatable;

	public bool activated;

	private TouchManager.TFGTouch startedTouch;

	public TFGButtonToggleGroup toggleGroup;

	public bool saveState;

	public bool multiTouch;

	public AudioClip pressClip;

	public AudioClip releaseClip;

	public AudioClip executeClip;

	public List<TextMesh> labels;

	private Transform cam;

	public bool debug;

	private bool inited;

	private Vector3 getCamPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Start()
	{
	}

	public void init()
	{
	}

	private void OnEnable()
	{
	}

	public void changeState(GameObject newState)
	{
	}

	public void setAllLabels(string label)
	{
	}

	public void setScrolled(TFGTouchScroll scroll)
	{
	}

	public Action addAction()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Action addAction(Action act)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Action getAction(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void executeAll()
	{
	}

	private void onTouchBegin(TouchManager.TFGTouch touch)
	{
	}

	public void deactivate()
	{
	}

	public void activate()
	{
	}

	public bool isActivated()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void onTouchEnded(TouchManager.TFGTouch touch)
	{
	}

	public bool sendButtonEnded()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void executeEnded()
	{
	}

	private void onTouchMoved(TouchManager.TFGTouch touch)
	{
	}

	private void onTouchStill(TouchManager.TFGTouch touch)
	{
	}

	private void onTouchEndedStill(TouchManager.TFGTouch touch)
	{
	}

	private void onTouchEntered(TouchManager.TFGTouch touch)
	{
	}

	private void onTouchLeave(TouchManager.TFGTouch touch)
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void setGreyed(bool greyed)
	{
	}
}
