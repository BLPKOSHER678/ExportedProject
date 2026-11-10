using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
	public float startDelay;

	private int selectedLevel;

	public TextMesh commingSoon;

	private void Start()
	{
	}

	private void OnSelectLevel(string level)
	{
	}

	[DebuggerHidden]
	private IEnumerator StartLevel()
	{
		return default;
	}

	private void OnOpen()
	{
	}
}
