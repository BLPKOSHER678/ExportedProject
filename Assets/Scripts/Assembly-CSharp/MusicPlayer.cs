using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
	public AudioClip music;

	public GameObject slave;

	public float volume;

	private static MusicPlayer _instance;

	public static MusicPlayer instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public void Awake()
	{
	}

	public void Start()
	{
	}

	public void Stop()
	{
	}
}
