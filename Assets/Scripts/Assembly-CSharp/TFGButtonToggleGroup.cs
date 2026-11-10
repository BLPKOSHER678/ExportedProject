using System.Collections.Generic;
using UnityEngine;

public class TFGButtonToggleGroup : MonoBehaviour
{
	private List<TFGButton> buttonList;

	public int startActive;

	public bool saveState;

	private void Start()
	{
	}

	public void refresh()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public TFGButton[] getGroupList()
	{
		return default;
	}

	public void untoggleAll()
	{
	}

	public void notifyActivated(TFGButton activeBut)
	{
	}
}
