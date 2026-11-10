using System.Collections.Generic;
using UnityEngine;

public class CFX_SpawnSystem : MonoBehaviour
{
	private static CFX_SpawnSystem instance;

	public GameObject[] objectsToPreload;

	public int[] objectsToPreloadTimes;

	public bool hideObjectsInHierarchy;

	private bool allObjectsLoaded;

	private Dictionary<int, List<GameObject>> instantiatedObjects;

	private Dictionary<int, int> poolCursors;

	public static bool AllObjectsLoaded
	{
		get
		{
			return default;
		}
	}

	public static GameObject GetNextObject(GameObject sourceObj, bool activateObject = true)
	{
		return default;
	}

	public static void PreloadObject(GameObject sourceObj, int poolSize = 1)
	{
	}

	public static void UnloadObjects(GameObject sourceObj)
	{
	}

	private void addObjectToPool(GameObject sourceObject, int number)
	{
	}

	private void removeObjectsFromPool(GameObject sourceObject)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}
}
