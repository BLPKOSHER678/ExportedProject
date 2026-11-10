using UnityEngine;

[ExecuteInEditMode]
public class OutlineNumber : MonoBehaviour
{
	public TextMesh baseNumber;

	public TextMesh[] outlines;

	public float spacing;

	public float depth;

	private string _text;

	public string text
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
