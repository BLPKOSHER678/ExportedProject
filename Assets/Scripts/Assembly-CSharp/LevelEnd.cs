using ChartboostSDK;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
	public TextMesh jumps;

	public TextMesh target1;

	public TextMesh target2;

	public Star[] levelStars;

	public bool test;

	public GameObject[] targetCircle1;

	public GameObject[] targetCircle2;

	public UnlockedPopup unlockedPopup;

	private void OnOpen()
	{
	}

	private void OnTransitionEnded()
	{
	}

	private void replayLevel()
	{
	}

	private void didFailToLoadInterstitial(CBLocation location, CBImpressionError error)
	{
	}

	private void didDismissInterstitial(CBLocation location)
	{
	}

	private void didCloseInterstitial(CBLocation location)
	{
	}

	private void didClickInterstitial(CBLocation location)
	{
	}

	private void didCacheInterstitial(CBLocation location)
	{
	}
}
