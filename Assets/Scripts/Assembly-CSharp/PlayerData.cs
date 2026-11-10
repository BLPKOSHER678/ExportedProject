using System;
using UnityEngine;

/// <summary>
/// Replacement for the stripped player progress manager. Save keys are new
/// recovery keys; compatibility with the original iOS save data is not asserted.
/// </summary>
public class PlayerData
{
    private static PlayerData _instance;
    public static PlayerData instance { get { return _instance ?? (_instance = new PlayerData()); } }

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

    public bool tutMorePage
    {
        get { return PlayerPrefs.GetInt("JJ.tutorial.more", 0) != 0; }
        set { PlayerPrefs.SetInt("JJ.tutorial.more", value ? 1 : 0); PlayerPrefs.Save(); }
    }
    public int NumLevels { get { return numLevels; } }
    public LevelData currentLevelData { get { return LevelData.getByID(currentLevel); } }

    private PlayerData()
    {
        getOptions();
        getTutorial();
        getJellyData();
        getItemData();
        getLevelData();
        currentLevel = Math.Max(0, PlayerPrefs.GetInt("JellyJump.CurrentLevel", 0));
        totalPlayCount = PlayerPrefs.GetInt("JJ.totalPlays", 0);
        played = PlayerPrefs.GetInt("JJ.played", 0) != 0;
        shopOfferCount = PlayerPrefs.GetInt("JJ.shopOffers", 0);
    }

    private void getOptions()
    {
        isSoundOn = PlayerPrefs.GetInt("JJ.sound", 1) != 0;
        isMusicOn = PlayerPrefs.GetInt("JJ.music", 1) != 0;
        graphicsQuality = PlayerPrefs.GetInt("JJ.quality", 1);
    }

    public void setOptions()
    {
        PlayerPrefs.SetInt("JJ.sound", isSoundOn ? 1 : 0);
        PlayerPrefs.SetInt("JJ.music", isMusicOn ? 1 : 0);
        PlayerPrefs.SetInt("JJ.quality", graphicsQuality);
        PlayerPrefs.Save();
    }

    private void getTutorial()
    {
        tutTips = getBoolArray("JJ.tutorial", 24);
    }

    private void setTutorial()
    {
        setBoolArray("JJ.tutorial", tutTips, tutTips == null ? 0 : tutTips.Length);
    }

    private void getJellyData()
    {
        currentJelly = PlayerPrefs.GetInt("JJ.currentJelly", 0);
        myJellies = getBoolArray("JJ.jellies", 32);
        if (myJellies.Length > 0) myJellies[0] = true;
    }

    public void setJellyData()
    {
        PlayerPrefs.SetInt("JJ.currentJelly", currentJelly);
        setBoolArray("JJ.jellies", myJellies, myJellies == null ? 0 : myJellies.Length);
        PlayerPrefs.Save();
    }

    private void getItemData()
    {
        hearts = PlayerPrefs.GetInt("JJ.hearts", 0);
        usedLifes = PlayerPrefs.GetInt("JJ.usedLives", 0);
        lifeCoinsCount = PlayerPrefs.GetInt("JJ.lifeCoins", 0);
        collectedLives = getBoolArray("JJ.collectedLives", 64);
    }

    public void setItemData()
    {
        PlayerPrefs.SetInt("JJ.hearts", hearts);
        PlayerPrefs.SetInt("JJ.usedLives", usedLifes);
        PlayerPrefs.SetInt("JJ.lifeCoins", lifeCoinsCount);
        setBoolArray("JJ.collectedLives", collectedLives, collectedLives == null ? 0 : collectedLives.Length);
        PlayerPrefs.Save();
    }

    // Compatibility entry point used by the recovered game controller.
    public void setItemDataForRecovery() { setItemData(); }

    public int getStarCount()
    {
        int total = 0;
        foreach (int v in levelstars) total += v;
        return total;
    }

    private void getLevelData()
    {
        numLevels = Math.Max(32, LevelData.LevelList.Length);
        bestJumps = new int[numLevels];
        levelPlayCount = new int[numLevels];
        levelstars = new int[numLevels];
        for (int i = 0; i < numLevels; ++i)
        {
            bestJumps[i] = PlayerPrefs.GetInt("JJ.best." + i, 0);
            levelPlayCount[i] = PlayerPrefs.GetInt("JJ.plays." + i, 0);
            levelstars[i] = PlayerPrefs.GetInt("JJ.stars." + i, 0);
        }
    }

    private void EnsureCapacity(int level)
    {
        if (level < numLevels) return;
        int capacity = Math.Max(level + 1, Math.Max(32, numLevels * 2));
        Array.Resize(ref bestJumps, capacity);
        Array.Resize(ref levelPlayCount, capacity);
        Array.Resize(ref levelstars, capacity);
        numLevels = capacity;
    }

    public void increaseTotalPlayCount()
    {
        totalPlayCount++;
        played = true;
        PlayerPrefs.SetInt("JJ.totalPlays", totalPlayCount);
        PlayerPrefs.SetInt("JJ.played", 1);
        PlayerPrefs.Save();
    }

    public string getCurrentLevelScene()
    {
        LevelData record = currentLevelData;
        if (record != null && !string.IsNullOrEmpty(record.sceneName)) return record.sceneName;
        GameControl game = GameControl.instance;
        if (game != null && game.levels != null && currentLevel >= 0 && currentLevel < game.levels.Length)
            return game.levels[currentLevel];
        return "L1";
    }

    public void setLevelRecord(int jumps) { setLevelRecord(currentLevel, jumps); }

    public void setLevelRecord(int level, int jumps)
    {
        if (level < 0 || jumps <= 0) return;
        EnsureCapacity(level);
        if (bestJumps[level] == 0 || jumps < bestJumps[level])
        {
            bestJumps[level] = jumps;
            PlayerPrefs.SetInt("JJ.best." + level, jumps);
            PlayerPrefs.Save();
        }
    }

    public int getLevelRecord(int level)
    {
        return level >= 0 && level < bestJumps.Length ? bestJumps[level] : 0;
    }

    public void setLevelStars(int level, int stars)
    {
        if (level < 0) return;
        EnsureCapacity(level);
        levelstars[level] = Math.Max(levelstars[level], stars);
        PlayerPrefs.SetInt("JJ.stars." + level, levelstars[level]);
        PlayerPrefs.Save();
    }

    public void setLevelStars(int stars) { setLevelStars(currentLevel, stars); }

    public int getLevelStars(int level)
    {
        return level >= 0 && level < levelstars.Length ? levelstars[level] : 0;
    }

    public void increaseLevelPlayCount(int level)
    {
        if (level < 0) return;
        EnsureCapacity(level);
        levelPlayCount[level]++;
        PlayerPrefs.SetInt("JJ.plays." + level, levelPlayCount[level]);
        PlayerPrefs.Save();
    }

    public int getLevelPlayCount(int level)
    {
        return level >= 0 && level < levelPlayCount.Length ? levelPlayCount[level] : 0;
    }

    public void setShopOffer()
    {
        shopOfferCount++;
        PlayerPrefs.SetInt("JJ.shopOffers", shopOfferCount);
        PlayerPrefs.Save();
    }

    private void getOffers() { shopOfferCount = PlayerPrefs.GetInt("JJ.shopOffers", 0); }

    private static bool[] getBoolArray(string name, int length)
    {
        return getBoolArray(name, length, false);
    }

    private static bool[] getBoolArray(string name, int length, bool defaultValue)
    {
        bool[] result = new bool[Math.Max(length, 0)];
        for (int i = 0; i < result.Length; i++)
            result[i] = PlayerPrefs.GetInt(name + "." + i, defaultValue ? 1 : 0) != 0;
        return result;
    }

    private static void setBoolArray(string name, bool[] data, int length)
    {
        if (data == null) return;
        for (int i = 0; i < length && i < data.Length; i++)
            PlayerPrefs.SetInt(name + "." + i, data[i] ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void setDebugSaves() { /* Do not reset progress during recovery. */ }
}
