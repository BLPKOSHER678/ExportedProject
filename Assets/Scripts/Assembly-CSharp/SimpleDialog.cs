using UnityEngine;

public class SimpleDialog : MonoBehaviour
{
	public string dialogMsg;

	public TextMesh dialogTextMesh;

	private TFGWindow window;

	public TFGWindow tfgWindow
	{
		get
		{
			return default;
		}
	}

	public void OnOpen()
	{
	}
}
