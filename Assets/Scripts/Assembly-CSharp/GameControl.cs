using UnityEngine;

public class GameControl : MonoBehaviour
{
	public enum DeathType
	{
		MONSTER = 0,
		HEIGHT = 1
	}

	public enum CoinType
	{
		HEART = 0,
		MEDAL = 1
	}

	public static int currentLevel;

	public int startLevel;

	public string[] levels;

	private int jumpCount;

	public int[] levelJumps;

	public int[] levelJumpsBest;

	private GameObject startPoint;

	private GameObject endPoint;

	public GameObject player;

	public CamControl gameCamera;

	private static bool firstScreen;

	public HUD hud;

	private bool finished;

	public GUIStyle layout;

	private static GameControl _instance;

	private bool canReset;

	private float resetTimer;

	public float resetTimeMonster;

	public float resetTimeHeight;

	public bool paused;

	public bool enableCoins;

	private int coinsCollected;

	private Checkpoint[] checkpoints;

	private static int enabledCheckpoint;

	private static int checkPointJumps;

	public static bool usedHeart;

	private bool levelStart;

	private float timeScaleBkp;

	public static GameControl instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void respawnJelly()
	{
	}

	private void Update()
	{
	}

	public void retryLevel()
	{
	}

	public void OnCancelRetry()
	{
	}

	public void getToEndPoint()
	{
	}

	public void playerDied(DeathType deathType)
	{
	}

	public bool isPlayerDied()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void resetLevel()
	{
	}

	public void nextLevel()
	{
	}

	public void spendJump()
	{
	}

	public int getJumpCount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void pauseGame()
	{
	}

	public void unpauseGame()
	{
	}

	public void collectCoin(CoinType type)
	{
	}

	public int getCoinsCollected()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void enableCheckpoint(int id)
	{
	}

	public int getCheckpointCount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void resetCheckPoints()
	{
	}
}
