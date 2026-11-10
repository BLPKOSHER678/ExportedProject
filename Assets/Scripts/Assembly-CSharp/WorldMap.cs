using System.Collections;
using System.Diagnostics;
using ChartboostSDK;
using UnityEngine;

public class WorldMap : MonoBehaviour
{
	public float startDelay;

	public MapControl mapControl;

	private int selectedLevel;

	private static WorldMap _instance;

	public Renderer[] worldPaths;

	public Material[] worldPathOnMaterials;

	public GameObject[] commingSoons;

	private bool[] worldOn;

	public TFGWindow loadingWin;

	public TextMesh starCounter;

	private bool toShowOffer;

	public static WorldMap instance
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

	private void checkShopOffer()
	{
	}

	private void showOffer()
	{
	}

	public bool isWorldOn(int world)
	{
		return default;
	}

	private void OnSelectLevel(string level)
	{
	}

	[DebuggerHidden]
	private IEnumerator StartLevel()
	{
		return default;
	}

	public void OnEndButtonEfx()
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
