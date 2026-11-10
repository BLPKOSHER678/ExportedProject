using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class NativeMessageReceiver : MonoBehaviour
{
	private static string javaInterfaceClass;

	private void Start()
	{
	}

	private void OnAppBecomeActive(string msg)
	{
	}

	private void OnProvideContent(string productID)
	{
	}

	private void OnGetProductPrices(string productPrices)
	{
	}

	private void OnRestoreProducts(string productRestore)
	{
	}

	private void OnBuyingCancel(string msg)
	{
	}

	public static void sendAnalyticsEvent(string eventType, Dictionary<string, string> info)
	{
	}

	public static void showPopupRating()
	{
	}

	public static void showPopupRatingWithDays()
	{
	}

	public static void scheduleLocalNotification(string message, string buttonText, double time)
	{
	}

	public static void scheduleLocalNotificationImediate(string message, string buttonText, double time)
	{
	}

	public static void requestProductInfo()
	{
	}

	public static void purchaseProduct(int productId)
	{
	}

	public static void restoreProducts()
	{
	}

	public static void onAutomationOK(int id)
	{
	}

	private void sendButtonPress(string buttonName)
	{
	}

	private void waitFor(string screenName)
	{
	}

	private void takeScreenshot(string filename)
	{
	}

	[DllImport("__Internal")]
	private static extern void setNotificationToBeSent(string message, string buttonText, double time);

	[DllImport("__Internal")]
	private static extern void sendNotificationImediate(string message, string buttonText, double time);

	[DllImport("__Internal")]
	private static extern void cprint(string msg);

	[DllImport("__Internal")]
	private static extern void popupRating();

	[DllImport("__Internal")]
	private static extern void sendAnalyticsEvent(string eventType, string[] keys, string[] values, int listSize);

	[DllImport("__Internal")]
	public static extern void requestProductData();

	[DllImport("__Internal")]
	public static extern void purchaseContent(int productId, bool firstTime);

	[DllImport("__Internal")]
	private static extern void requestRestoreProducts();

	public static void cPrint(string msg)
	{
	}
}
