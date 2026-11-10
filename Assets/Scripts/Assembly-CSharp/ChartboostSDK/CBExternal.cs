using System;
using System.Runtime.InteropServices;

namespace ChartboostSDK
{
	public class CBExternal
	{
		private static bool initialized;

		private static string _logTag;

		public static void Log(string message)
		{
		}

		private static bool checkInitialized()
		{
			return default;
		}

		[DllImport("__Internal")]
		private static extern void _chartBoostInit(string appId, string appSignature);

		[DllImport("__Internal")]
		private static extern bool _chartBoostIsAnyViewVisible();

		[DllImport("__Internal")]
		private static extern void _chartBoostCacheInterstitial(string location);

		[DllImport("__Internal")]
		private static extern bool _chartBoostHasInterstitial(string location);

		[DllImport("__Internal")]
		private static extern void _chartBoostShowInterstitial(string location);

		[DllImport("__Internal")]
		private static extern void _chartBoostCacheRewardedVideo(string location);

		[DllImport("__Internal")]
		private static extern bool _chartBoostHasRewardedVideo(string location);

		[DllImport("__Internal")]
		private static extern void _chartBoostShowRewardedVideo(string location);

		[DllImport("__Internal")]
		private static extern void _chartBoostCacheMoreApps(string location);

		[DllImport("__Internal")]
		private static extern bool _chartBoostHasMoreApps(string location);

		[DllImport("__Internal")]
		private static extern void _chartBoostShowMoreApps(string location);

		[DllImport("__Internal")]
		private static extern void _chartBoostCacheInPlay(string location);

		[DllImport("__Internal")]
		private static extern bool _chartBoostHasInPlay(string location);

		[DllImport("__Internal")]
		private static extern IntPtr _chartBoostGetInPlay(string location);

		[DllImport("__Internal")]
		private static extern void _chartBoostSetCustomId(string id);

		[DllImport("__Internal")]
		private static extern void _chartBoostDidPassAgeGate(bool pass);

		[DllImport("__Internal")]
		private static extern string _chartBoostGetCustomId();

		[DllImport("__Internal")]
		private static extern void _chartBoostHandleOpenURL(string url, string sourceApp);

		[DllImport("__Internal")]
		private static extern void _chartBoostSetShouldPauseClickForConfirmation(bool pause);

		[DllImport("__Internal")]
		private static extern void _chartBoostSetShouldRequestInterstitialsInFirstSession(bool request);

		[DllImport("__Internal")]
		private static extern void _chartBoostShouldDisplayInterstitialCallbackResult(bool result);

		[DllImport("__Internal")]
		private static extern void _chartBoostShouldDisplayRewardedVideoCallbackResult(bool result);

		[DllImport("__Internal")]
		private static extern void _chartBoostShouldDisplayMoreAppsCallbackResult(bool result);

		[DllImport("__Internal")]
		private static extern bool _chartBoostGetAutoCacheAds();

		[DllImport("__Internal")]
		private static extern void _chartBoostSetAutoCacheAds(bool autoCacheAds);

		[DllImport("__Internal")]
		private static extern void _chartBoostSetShouldDisplayLoadingViewForMoreApps(bool shouldDisplay);

		[DllImport("__Internal")]
		private static extern void _chartBoostSetShouldPrefetchVideoContent(bool shouldDisplay);

		[DllImport("__Internal")]
		private static extern void _chartBoostTrackInAppPurchaseEvent(string receipt, string productTitle, string productDescription, string productPrice, string productCurrency, string productIdentifier);

		[DllImport("__Internal")]
		private static extern void _chartBoostSetGameObjectName(string name);

		public static void init()
		{
		}

		public static bool isAnyViewVisible()
		{
			return default;
		}

		public static void cacheInterstitial(CBLocation location)
		{
		}

		public static bool hasInterstitial(CBLocation location)
		{
			return default;
		}

		public static void showInterstitial(CBLocation location)
		{
		}

		public static void cacheMoreApps(CBLocation location)
		{
		}

		public static bool hasMoreApps(CBLocation location)
		{
			return default;
		}

		public static void showMoreApps(CBLocation location)
		{
		}

		public static void cacheInPlay(CBLocation location)
		{
		}

		public static bool hasInPlay(CBLocation location)
		{
			return default;
		}

		public static CBInPlay getInPlay(CBLocation location)
		{
			return default;
		}

		public static void cacheRewardedVideo(CBLocation location)
		{
		}

		public static bool hasRewardedVideo(CBLocation location)
		{
			return default;
		}

		public static void showRewardedVideo(CBLocation location)
		{
		}

		public static void chartBoostShouldDisplayInterstitialCallbackResult(bool result)
		{
		}

		public static void chartBoostShouldDisplayRewardedVideoCallbackResult(bool result)
		{
		}

		public static void chartBoostShouldDisplayMoreAppsCallbackResult(bool result)
		{
		}

		public static void setCustomId(string id)
		{
		}

		public static string getCustomId()
		{
			return default;
		}

		public static void didPassAgeGate(bool pass)
		{
		}

		public static void handleOpenURL(string url, string sourceApp)
		{
		}

		public static void setShouldPauseClickForConfirmation(bool pause)
		{
		}

		public static void setShouldRequestInterstitialsInFirstSession(bool request)
		{
		}

		public static void setGameObjectName(string name)
		{
		}

		public static bool getAutoCacheAds()
		{
			return default;
		}

		public static void setAutoCacheAds(bool autoCacheAds)
		{
		}

		public static void setShouldDisplayLoadingViewForMoreApps(bool shouldDisplay)
		{
		}

		public static void setShouldPrefetchVideoContent(bool shouldPrefetch)
		{
		}

		public static void trackInAppAppleStorePurchaseEvent(string receipt, string productTitle, string productDescription, string productPrice, string productCurrency, string productIdentifier)
		{
		}
	}
}
