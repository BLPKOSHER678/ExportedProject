using UnityEngine;

public class TFGPage : MonoBehaviour
{
	public float moveSpeed;

	private float moveDelta;

	private bool keepMoving;

	private int target;

	public float moveThreshold;

	public Transform[] pages;

	public float keepMoveSpeed;

	public int startPage;

	public float pageSpacing;

	public GameObject[] radioIndicators;

	public GameObject moreArrow;

	private float moveAdjust;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnOpen()
	{
	}

	private void updatePageIndicator()
	{
	}

	public void setPage(int page)
	{
	}
}
