using UnityEngine;

public class MapButton : MonoBehaviour
{
	public int levelIndex;

	private TFGButton button;

	private bool performEffect;

	public float newEffectTime;

	private float efxTimer;

	public GameObject[] starsObj;

	public GameObject nextLevelFx;

	public GameObject newLevelFx;

	public AudioClip unlockSound;

	private bool audioPlayed;

	public Material newLevelMat;

	public Material completeLevelMat;

	public Renderer[] buttonRenderers;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private int calculateStars(int level, int jumpCount)
	{
		return default;
	}
}
