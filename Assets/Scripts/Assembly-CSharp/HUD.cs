using UnityEngine;

public class HUD : MonoBehaviour
{
	public bool hudOn;

	public int bestJumps;

	public GameControl gameControl;

	public bool firstScreen;

	public bool finished;

	public int currentLevel;

	public int[] starJumps;

	private int targetJumps;

	public TextMesh levelJumpsText;

	public TextMesh levelCountText;

	private bool showJumpTarget;

	public TFGButton pauseButton;

	public TFGButton retryButton;

	public int JumpCount
	{
		set
		{
            if (levelJumpsText != null) levelJumpsText.text = value.ToString();
		}
	}

	private void Start()
	{
        if (gameControl == null) gameControl = FindObjectOfType<GameControl>();
        resetLevel();
	}

	public void resetLevel()
	{
        finished = false;
        if (levelJumpsText != null) levelJumpsText.text = "0";
        if (levelCountText != null) levelCountText.text = (GameControl.currentLevel + 1).ToString();
        unblockButtons();
	}

	public void blockButtons()
	{
        if (pauseButton != null) pauseButton.enabled = false;
        if (retryButton != null) retryButton.enabled = false;
	}

	public void unblockButtons()
	{
        if (pauseButton != null) pauseButton.enabled = true;
        if (retryButton != null) retryButton.enabled = true;
	}
}
