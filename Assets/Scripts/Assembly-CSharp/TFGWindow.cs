using System.Collections.Generic;
using UnityEngine;

public class TFGWindow : MonoBehaviour
{
	public enum State
	{
		opening = 0,
		open = 1,
		closing = 2,
		closed = 3
	}

	public interface Listener
	{
		void LstOnOpen();

		void LstOnClose();

		void LstOnTransitionEnded();
	}

	public bool openingTransitionOn;

	public bool closingTransitionOn;

	public TFGTransition openingTransition;

	public TFGTransition closingTransition;

	private State state;

	private bool toClose;

	private bool toOpen;

	public List<TFGWindow> enabledWindows;

	private Vector3 savePosition;

	private Quaternion saveRotation;

	private bool firstOpen;

	private float[] alphaBkps;

	private List<Renderer> childRenderers;

	public TFGWindow[] toOpenOnOpen;

	public TFGWindow[] toCloseOnOpen;

	public TFGWindow[] toOpenOnClose;

	public TFGWindow[] toCloseOnClose;

	private bool dirty;

	private List<Listener> listeners;

	private bool toSendTransitionEnded;

	public bool debug;

	private bool cancel;

	private bool cancelChildWindows;

	public float[] AlphaBKP
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public List<Renderer> ChildRenderers
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public void addListener(Listener listener)
	{
	}

	public void setDirty()
	{
	}

	public void Load()
	{
	}

	public void refreshChilds()
	{
	}

	private void findChildRenderers(Transform transform)
	{
	}

	private void resetTransform()
	{
	}

	private void Update()
	{
	}

	private void updateIdle()
	{
	}

	private void updateClosed()
	{
	}

	public void cancelOpen()
	{
	}

	public void cancelOpenChildWindows()
	{
	}

	public void open()
	{
	}

	public void changeState(State newState)
	{
	}

	public bool isClosed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool isOpen()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void updateOpening()
	{
	}

	public bool finishedOpening()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void close()
	{
	}

	public void OnDisable()
	{
	}

	private void updateClosing()
	{
	}

	public bool finishedClosing()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public TFGWindow[] getChildWindows()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnDrawGizmos()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
