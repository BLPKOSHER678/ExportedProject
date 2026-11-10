using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class IAPCaller : MonoBehaviour, TFGWindow.Listener
{
	private enum State
	{
		Idle = 0,
		Requesting = 1,
		Buying = 2,
		Restoring = 3,
		Canceling = 4
	}

	private State state;

	public static string[] productDescription;

	private static string[] _productPrices;

	private static string defaultPrices;

	private static IAPCaller _instance;

	public TFGWindow loadingWinMsg;

	private int currentBuying;

	public int toBuyProduct;

	public TFGWindow popup;

	public bool simulatorBuy;

	public int simulatorRestore;

	public GameObject callBack;

	public GameObject processAnim;

	private bool resultConfirm;

	public bool debugMode;

	private static int buyingProduct;

	public static string[] productPrices
	{
		get
		{
			return default;
		}
	}

	public static IAPCaller instance
	{
		get
		{
			return default;
		}
	}

	public void Awake()
	{
	}

	public void requestBuyProduct(string prodId)
	{
	}

	public void requestBuyProduct(string prodId, GameObject callBack)
	{
	}

	private void Update()
	{
	}

	public void OnBuyProduct(string id)
	{
	}

	public void OnRequestRestore(GameObject callBack)
	{
	}

	public void OnRequestRestore()
	{
	}

	[DebuggerHidden]
	private IEnumerator buySimulator(bool confirmBuy)
	{
		return default;
	}

	[DebuggerHidden]
	private IEnumerator restoreSimulator(int toRestore)
	{
		return default;
	}

	public void OnProvideProduct(string productID)
	{
	}

	public static void OnGetProductPrices(string productPriceList)
	{
	}

	public static void OnRestoreProducts(string productRestore)
	{
	}

	private static string[] parseProductPrices(string productPriceList)
	{
		return default;
	}

	public static void OnBuyingCancel()
	{
	}

	public void LstOnClose()
	{
	}

	public void LstOnOpen()
	{
	}

	public void LstOnTransitionEnded()
	{
	}
}
