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
		}
	}

	private void Start()
	{
	}

	public void resetLevel()
	{
	}

	public void blockButtons()
	{
	}

	public void unblockButtons()
	{
	}
}
