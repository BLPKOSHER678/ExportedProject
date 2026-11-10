using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TFGInterfaceManager : MonoBehaviour
{
	private bool start;

	private static TFGInterfaceManager _instance;

	public Camera GuiCamera;

	public static string screenToLoad;

	public static bool transitioning;

	public static bool showingDialog;

	public string startScreen;

	public bool autoLoadScreen;

	private string currentScreen;

	private string previousScreen;

	private List<TFGTransition> runningTransitions;

	private float lastTime;

	private static float timeScaleBkp;

	private GameObject backButtonTarget;

	private string backButtonMethod;

	private string backButtonParam;

	private static int count;

	public static TFGInterfaceManager instance
	{
		get
		{
			return default;
		}
	}

	public float deltaTime
	{
		get
		{
			return default;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void loadFirstScreen()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void setBackButtonAction(string methodName, string parameter)
	{
	}

	public void setBackButtonAction(GameObject target, string methodName, string parameter)
	{
	}

	public TFGWindow getActiveScreen()
	{
		return default;
	}

	public void back()
	{
	}

	public void changeAtiveScreen(string screenName)
	{
	}

	public void addRunningTransition(TFGTransition newTransition)
	{
	}

	public void removeEndedTransition(TFGTransition oldTransition)
	{
	}

	public TFGWindow[] getScreenList()
	{
		return default;
	}

	public TFGWindow getScreenWindow(string name)
	{
		return default;
	}
}
