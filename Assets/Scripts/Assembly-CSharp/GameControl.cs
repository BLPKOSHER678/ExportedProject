using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private bool dead;
    private Coroutine loadJob;
    private string loadedSceneName;

    private void RefreshMissingLevels()
    {
        bool stale = levels == null || levels.Length == 0;
        if (!stale)
            foreach (string sceneName in levels)
                if (!Application.CanStreamedLevelBeLoaded(sceneName)) { stale = true; break; }
        if (!stale) return;

        System.Collections.Generic.List<string> available = new System.Collections.Generic.List<string>();
        for (int index = 1; index < SceneManager.sceneCountInBuildSettings; index++)
        {
            string path = SceneUtility.GetScenePathByBuildIndex(index);
            string name = System.IO.Path.GetFileNameWithoutExtension(path);
            if (!string.IsNullOrEmpty(name)) available.Add(name);
        }
        if (available.Count > 0) levels = available.ToArray();
    }

    private IEnumerator NextLevelAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        if (this != null && finished) nextLevel();
    }

    private IEnumerator LoadLevel(int requested)
    {
        if (levels == null || levels.Length == 0) yield break;
        int selected = requested;
        while (selected < levels.Length && !Application.CanStreamedLevelBeLoaded(levels[selected])) selected++;
        if (selected >= levels.Length)
        {
            Debug.LogWarning("Jelly Jump: no more restored playable levels in Build Settings.");
            yield break;
        }
        currentLevel = selected;
        if (!string.IsNullOrEmpty(loadedSceneName))
        {
            Scene oldScene = SceneManager.GetSceneByName(loadedSceneName);
            if (oldScene.IsValid() && oldScene.isLoaded)
                yield return SceneManager.UnloadSceneAsync(oldScene);
        }
        loadedSceneName = levels[selected];
        yield return SceneManager.LoadSceneAsync(loadedSceneName, LoadSceneMode.Additive);
        startPoint = null;
        endPoint = null;
        Scene currentScene = SceneManager.GetSceneByName(loadedSceneName);
        if (currentScene.IsValid() && currentScene.isLoaded)
        {
            foreach (GameObject root in currentScene.GetRootGameObjects())
            {
                Level level = root.GetComponentInChildren<Level>(true);
                if (level != null)
                {
                    if (level.startPoint != null) startPoint = level.startPoint.gameObject;
                    if (level.endPoint != null) endPoint = level.endPoint.gameObject;
                    break;
                }
            }
        }
        ResetLevelAfterLoad();
        loadJob = null;
    }

    private void ResetLevelAfterLoad()
    {
        resetCheckPoints();
        resetLevel();
    }

	public static GameControl instance
	{
		get
		{
			return _instance;
		}
	}

	private void Awake()
	{
        _instance = this;
        Time.timeScale = 1f;
        timeScaleBkp = 1f;
        if (gameCamera == null) gameCamera = FindObjectOfType<CamControl>();
        if (hud == null) hud = FindObjectOfType<HUD>();
	}

	private void Start()
	{
        RefreshMissingLevels();
        if (levels == null || levels.Length == 0) { Debug.LogError("Jelly Jump: no levels are configured."); return; }
        currentLevel = Mathf.Clamp(PlayerData.instance.currentLevel, 0, levels.Length - 1);
        if (startLevel > 0) currentLevel = Mathf.Clamp(startLevel, 0, levels.Length - 1);
        StartCoroutine(LoadLevel(currentLevel));
	}

	private void respawnJelly()
	{
        if (player == null)
        {
            CharacterControl existing = FindObjectOfType<CharacterControl>();
            if (existing != null) player = existing.gameObject;
        }
        if (player == null)
        {
            // Temporary playable fallback; the original jelly model must still be restored.
            player = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            player.name = "Jelly (reconstructed fallback)";
            // Keep a small, invisible sphere collider for 2.5D physics.
            // The visible character is built separately to approximate the reference footage.
            player.transform.localScale = Vector3.one * 0.75f;
            MeshRenderer placeholderRenderer = player.GetComponent<MeshRenderer>();
            if (placeholderRenderer != null) placeholderRenderer.enabled = false;
            Rigidbody body = player.AddComponent<Rigidbody>();
            body.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
            player.AddComponent<CharacterControl>();
            player.AddComponent<RecoveredJellyVisual>();
        }
        CharacterControl control = player.GetComponent<CharacterControl>();
        if (control != null) { control.gameControl = this; control.reset(); }
        if (startPoint != null) player.transform.position = startPoint.transform.position;
        if (gameCamera != null) { gameCamera.target = player.transform; gameCamera.init(); }
	}

	private void Update()
	{
        if (canReset && !paused && !finished)
        {
            resetTimer -= Time.deltaTime;
            if (resetTimer <= 0f) { canReset = false; resetLevel(); }
        }
	}

	public void retryLevel()
	{
        if (loadJob != null) StopCoroutine(loadJob);
        dead = false; finished = false; canReset = false;
        loadJob = StartCoroutine(LoadLevel(currentLevel));
	}

	public void OnCancelRetry()
	{
        canReset = false;
        dead = false;
	}

	public void getToEndPoint()
	{
        if (finished || dead) return;
        finished = true;
        if (player != null)
        {
            CharacterControl control = player.GetComponent<CharacterControl>();
            if (control != null) control.EndingJump();
        }
        if (hud != null) hud.finished = true;
        PlayerData.instance.setLevelRecord(currentLevel, jumpCount);
        PlayerData.instance.currentLevel = Mathf.Max(PlayerData.instance.currentLevel, currentLevel + 1);
        PlayerPrefs.SetInt("JellyJump.CurrentLevel", PlayerData.instance.currentLevel);
        PlayerPrefs.Save();
        StartCoroutine(NextLevelAfterDelay());
	}

	public void playerDied(DeathType deathType)
	{
        if (dead || finished) return;
        dead = true;
        canReset = true;
        resetTimer = Mathf.Max(0.2f, deathType == DeathType.MONSTER ? resetTimeMonster : resetTimeHeight);
        PlayerData.instance.currentLevelDeathCount++;
        if (player != null)
        {
            CharacterAnimator animator = player.GetComponent<CharacterAnimator>();
            if (animator != null)
            {
                if (deathType == DeathType.MONSTER) animator.dieEnemy();
                else animator.dieHeight();
            }
        }
	}

	public bool isPlayerDied()
	{
        return dead;
	}

	public void resetLevel()
	{
        dead = false; finished = false; canReset = false;
        jumpCount = 0;
        coinsCollected = 0;
        respawnJelly();
        if (hud != null) { hud.finished = false; hud.resetLevel(); hud.JumpCount = 0; }
	}

	public void nextLevel()
	{
        if (loadJob != null) StopCoroutine(loadJob);
        int next = Mathf.Clamp(currentLevel + 1, 0, Mathf.Max(0, levels.Length - 1));
        loadJob = StartCoroutine(LoadLevel(next));
	}

	public void spendJump()
	{
        jumpCount++;
        if (hud != null) hud.JumpCount = jumpCount;
	}

	public int getJumpCount()
	{
        return jumpCount;
	}

	public void pauseGame()
	{
        if (paused) return;
        paused = true;
        timeScaleBkp = Time.timeScale;
        Time.timeScale = 0f;
	}

	public void unpauseGame()
	{
        paused = false;
        Time.timeScale = timeScaleBkp > 0f ? timeScaleBkp : 1f;
	}

	public void collectCoin(CoinType type)
	{
        coinsCollected++;
        if (type == CoinType.HEART) { PlayerData.instance.hearts++; PlayerData.instance.setItemDataForRecovery(); }
	}

	public int getCoinsCollected()
	{
        return coinsCollected;
	}

	public void enableCheckpoint(int id)
	{
        enabledCheckpoint = id;
        checkPointJumps = jumpCount;
	}

	public int getCheckpointCount()
	{
        return checkpoints != null ? checkpoints.Length : 0;
	}

	public static void resetCheckPoints()
	{
        enabledCheckpoint = 0;
        checkPointJumps = 0;
	}
}
