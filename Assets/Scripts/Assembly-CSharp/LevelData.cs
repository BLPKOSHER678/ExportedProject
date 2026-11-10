using UnityEngine;

public class LevelData : ScriptableObject
{
	private static LevelData[] _levelList;

	public int id;

	public bool active;

	public int star2jumps;

	public int star3jumps;

	public string sceneName;

	private int _order;

	public static LevelData[] LevelList
	{
		get
		{
			return default;
		}
	}

	public int order
	{
		get
		{
			return default;
		}
	}

	public static LevelData getByID(int id)
	{
		return default;
	}
}
