using UnityEngine;

public class GlobalConfig : ScriptableObject
{
	private static GlobalConfig _instance;

	public int defaultJelly;

	public Jelly[] jellyList;

	public int startingHearts;

	public int[] jellyShopPopupIntervals;

	public int[] jellyOffertOrder;

	public int[] WorldLevelCounts;

	public AudioClip buttonPressedClip;

	public AudioClip buttonReleasedClip;

	public AudioClip buttonExecuteClip;

	public float aspectRatio;

	public int levelToPopupRating;

	public int daysToPopupRating;

	public string buildDate;

	public static GlobalConfig instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}
}
