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
			return default;
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
