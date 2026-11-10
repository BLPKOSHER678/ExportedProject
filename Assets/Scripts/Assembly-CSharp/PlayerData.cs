public class PlayerData
{
	private static PlayerData _instance;

	public bool isSoundOn;

	public bool isMusicOn;

	public int graphicsQuality;

	private int optionsSize;

	private bool[] tutTips;

	public int currentJelly;

	public bool[] myJellies;

	private int lifeCoinsCount;

	public int hearts;

	public int usedLifes;

	public bool[] collectedLives;

	private int numLevels;

	private int[] bestJumps;

	private int[] levelPlayCount;

	public int currentLevel;

	private int[] levelstars;

	public bool played;

	public int totalPlayCount;

	public bool showNewLevelEffect;

	public int currentLevelDeathCount;

	public int currentLevelRetryCount;

	public int shopOfferCount;

	public int jellyOfferCicleIdx;

	public static PlayerData instance
	{
		get
		{
			return default;
		}
	}

	public bool tutMorePage
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public int NumLevels
	{
		get
		{
			return default;
		}
	}

	public LevelData currentLevelData
	{
		get
		{
			return default;
		}
	}

	private PlayerData()
	{
	}

	private void getOptions()
	{
	}

	public void setOptions()
	{
	}

	private void getTutorial()
	{
	}

	private void setTutorial()
	{
	}

	private void getJellyData()
	{
	}

	public void setJellyData()
	{
	}

	private void getItemData()
	{
	}

	public void setItemData()
	{
	}

	public int getStarCount()
	{
		return default;
	}

	private void getLevelData()
	{
	}

	public void increaseTotalPlayCount()
	{
	}

	public string getCurrentLevelScene()
	{
		return default;
	}

	public void setLevelRecord(int jumps)
	{
	}

	public void setLevelRecord(int level, int jumps)
	{
	}

	public int getLevelRecord(int level)
	{
		return default;
	}

	public void setLevelStars(int level, int stars)
	{
	}

	public void setLevelStars(int stars)
	{
	}

	public int getLevelStars(int level)
	{
		return default;
	}

	public void increaseLevelPlayCount(int level)
	{
	}

	public int getLevelPlayCount(int level)
	{
		return default;
	}

	public void setShopOffer()
	{
	}

	private void getOffers()
	{
	}

	private static bool[] getBoolArray(string name, int length)
	{
		return default;
	}

	private static bool[] getBoolArray(string name, int length, bool defaultValue)
	{
		return default;
	}

	private static void setBoolArray(string name, bool[] data, int length)
	{
	}

	public void setDebugSaves()
	{
	}
}
