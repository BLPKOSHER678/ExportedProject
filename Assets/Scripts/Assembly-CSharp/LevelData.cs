using UnityEngine;

/// <summary>
/// Identifies an individual restored level. Original serialized fields are kept.
/// </summary>
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
            if (_levelList == null)
            {
                _levelList = Resources.LoadAll<LevelData>("");
                System.Array.Sort(_levelList, (a, b) => a.id.CompareTo(b.id));
            }
            return _levelList;
        }
    }

    public int order
    {
        get
        {
            for (int i = 0; i < LevelList.Length; i++)
                if (LevelList[i] == this) return i;
            return _order;
        }
    }

    public static LevelData getByID(int id)
    {
        foreach (LevelData record in LevelList)
            if (record != null && record.id == id) return record;
        return null;
    }
}
