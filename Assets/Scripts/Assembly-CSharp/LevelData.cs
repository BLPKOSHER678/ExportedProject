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
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int order
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static LevelData getByID(int id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
