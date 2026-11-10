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
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool tutMorePage
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int NumLevels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public LevelData currentLevelData
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void getLevelData()
	{
	}

	public void increaseTotalPlayCount()
	{
	}

	public string getCurrentLevelScene()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void setLevelRecord(int jumps)
	{
	}

	public void setLevelRecord(int level, int jumps)
	{
	}

	public int getLevelRecord(int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void setLevelStars(int level, int stars)
	{
	}

	public void setLevelStars(int stars)
	{
	}

	public int getLevelStars(int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void increaseLevelPlayCount(int level)
	{
	}

	public int getLevelPlayCount(int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void setShopOffer()
	{
	}

	private void getOffers()
	{
	}

	private static bool[] getBoolArray(string name, int length)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static bool[] getBoolArray(string name, int length, bool defaultValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static void setBoolArray(string name, bool[] data, int length)
	{
	}

	public void setDebugSaves()
	{
	}
}
