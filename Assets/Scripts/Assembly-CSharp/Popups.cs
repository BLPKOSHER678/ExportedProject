using UnityEngine;

public class Popups : MonoBehaviour
{
	private class Dialog
	{
		public string caption;

		public string content;

		public string accept;

		public string decline;

		public TFGButton.Action acceptAct;

		public TFGButton.Action declineAct;

		public Texture2D pic;
	}

	public DialogPopup dialog1;

	public DialogPopup dialog2;

	public DialogPopup basicDialog;

	private static Popups _instance;

	private static Dialog scheduled;

	public static Popups instance
	{
		get
		{
			return default;
		}
	}

	private void Awake()
	{
	}

	public static TFGWindow getPopup(string name)
	{
		return default;
	}

	public static void scheduleDialog1(string caption, string content, string accept, string decline, TFGButton.Action acceptAct, TFGButton.Action declineAct, Texture2D pic)
	{
	}

	public static void showDialog1(string caption, string content, string accept, string decline, TFGButton.Action acceptAct, TFGButton.Action declineAct, Texture2D pic)
	{
	}

	public static void showDialog2(string caption, string content, string accept, TFGButton.Action acceptAct, Texture2D pic)
	{
	}

	public static void showBasicDialog(string caption, string content, string accept, string decline, TFGButton.Action acceptAct, TFGButton.Action declineAct)
	{
	}

	public static void cancelDialog()
	{
	}

	private void Update()
	{
	}
}
