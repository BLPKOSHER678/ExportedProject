using UnityEngine;

public class JellyCard : MonoBehaviour
{
	public enum CardState
	{
		SELECTED = 0,
		OWNED = 1,
		TOBUY = 2
	}

	public int jellyId;

	public TextMesh JellyName;

	public TFGButton buyButton;

	public TFGButton selectButton;

	public TextMesh ConditionValue;

	public TextMesh jellyHabilityDesc;

	public GameObject conditionGroup;

	public Transform jellyModel;

	private CardState state;

	public CardState State
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public void setInfo(string jellyName, string habilityDesc, int conditionValue)
	{
	}
}
