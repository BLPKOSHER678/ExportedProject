using UnityEngine;

public class DialogPopup : Popup
{
	public string caption;

	public string content;

	public string accept;

	public string decline;

	public Texture2D pic;

	public Renderer picPlane;

	public TFGButton acceptButton;

	public TFGButton declineButton;

	public TextMesh captionText;

	public TextMesh contentText;

	public float acceptSize;

	public float declineSize;

	public float captionSize;

	public float acceptMaxChar;

	public float declineMaxChar;

	public float captionMaxChar;

	public void applyValues()
	{
	}
}
