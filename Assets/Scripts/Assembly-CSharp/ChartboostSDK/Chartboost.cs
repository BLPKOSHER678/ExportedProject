using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartboostSDK
{
	public class Chartboost : MonoBehaviour
	{
		private static bool isPaused;

		private static float lastTimeScale;

		private static Func<CBLocation, bool> m_shouldDisplayInterstitial;

		private static Action<CBLocation> m_didDisplayInterstitial;

		private static Action<CBLocation> m_didCacheInterstitial;

		private static Action<CBLocation> m_didClickInterstitial;

		private static Action<CBLocation> m_didCloseInterstitial;

		private static Action<CBLocation> m_didDismissInterstitial;

		private static Action<CBLocation, CBImpressionError> m_didFailToLoadInterstitial;

		private static Action<CBLocation, CBImpressionError> m_didFailToRecordClick;

		private static Func<CBLocation, bool> m_shouldDisplayMoreApps;

		private static Action<CBLocation> m_didDisplayMoreApps;

		private static Action<CBLocation> m_didCacheMoreApps;

		private static Action<CBLocation> m_didClickMoreApps;

		private static Action<CBLocation> m_didCloseMoreApps;

		private static Action<CBLocation> m_didDismissMoreApps;

		private static Action<CBLocation, CBImpressionError> m_didFailToLoadMoreApps;

		private static Func<CBLocation, bool> m_shouldDisplayRewardedVideo;

		private static Action<CBLocation> m_didDisplayRewardedVideo;

		private static Action<CBLocation> m_didCacheRewardedVideo;

		private static Action<CBLocation> m_didClickRewardedVideo;

		private static Action<CBLocation> m_didCloseRewardedVideo;

		private static Action<CBLocation> m_didDismissRewardedVideo;

		private static Action<CBLocation, int> m_didCompleteRewardedVideo;

		private static Action<CBLocation, CBImpressionError> m_didFailToLoadRewardedVideo;

		private static Action<CBLocation> m_didCacheInPlay;

		private static Action<CBLocation, CBImpressionError> m_didFailToLoadInPlay;

		private static Action<CBLocation> m_willDisplayVideo;

		private static Action m_didPauseClickForConfirmation;

		private static Action m_didCompleteAppStoreSheetFlow;

		public static event Func<CBLocation, bool> shouldDisplayInterstitial
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didDisplayInterstitial
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didCacheInterstitial
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didClickInterstitial
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didCloseInterstitial
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didDismissInterstitial
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation, CBImpressionError> didFailToLoadInterstitial
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation, CBImpressionError> didFailToRecordClick
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Func<CBLocation, bool> shouldDisplayMoreApps
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didDisplayMoreApps
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didCacheMoreApps
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didClickMoreApps
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didCloseMoreApps
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didDismissMoreApps
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation, CBImpressionError> didFailToLoadMoreApps
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Func<CBLocation, bool> shouldDisplayRewardedVideo
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didDisplayRewardedVideo
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didCacheRewardedVideo
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didClickRewardedVideo
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didCloseRewardedVideo
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didDismissRewardedVideo
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation, int> didCompleteRewardedVideo
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation, CBImpressionError> didFailToLoadRewardedVideo
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> didCacheInPlay
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation, CBImpressionError> didFailToLoadInPlay
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action<CBLocation> willDisplayVideo
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action didPauseClickForConfirmation
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static event Action didCompleteAppStoreSheetFlow
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		public static void isAnyViewVisible()
		{
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

		public static void didPassAgeGate(bool pass)
		{
		}

		public static void setShouldPauseClickForConfirmation(bool shouldPause)
		{
		}

		public static string getCustomId()
		{
			return default;
		}

		public static void setCustomId(string customId)
		{
		}

		public static bool getAutoCacheAds()
		{
			return default;
		}

		public static void setAutoCacheAds(bool autoCacheAds)
		{
		}

		public static void setShouldRequestInterstitialsInFirstSession(bool shouldRequest)
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

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnApplicationPause(bool paused)
		{
		}

		private void OnDisable()
		{
		}

		private static CBImpressionError impressionErrorFromInt(object errorObj)
		{
			return default;
		}

		private void didFailToLoadInterstitialEvent(string dataString)
		{
		}

		private void didDismissInterstitialEvent(string location)
		{
		}

		private void didClickInterstitialEvent(string location)
		{
		}

		private void didCloseInterstitialEvent(string location)
		{
		}

		private void didCacheInterstitialEvent(string location)
		{
		}

		private void shouldDisplayInterstitialEvent(string location)
		{
		}

		public void didDisplayInterstitialEvent(string location)
		{
		}

		private void didFailToLoadMoreAppsEvent(string dataString)
		{
		}

		private void didDismissMoreAppsEvent(string location)
		{
		}

		private void didClickMoreAppsEvent(string location)
		{
		}

		private void didCloseMoreAppsEvent(string location)
		{
		}

		private void didCacheMoreAppsEvent(string location)
		{
		}

		private void shouldDisplayMoreAppsEvent(string location)
		{
		}

		private void didDisplayMoreAppsEvent(string location)
		{
		}

		private void didFailToRecordClickEvent(string dataString)
		{
		}

		private void didFailToLoadRewardedVideoEvent(string dataString)
		{
		}

		private void didDismissRewardedVideoEvent(string location)
		{
		}

		private void didClickRewardedVideoEvent(string location)
		{
		}

		private void didCloseRewardedVideoEvent(string location)
		{
		}

		private void didCacheRewardedVideoEvent(string location)
		{
		}

		private void shouldDisplayRewardedVideoEvent(string location)
		{
		}

		private void didCompleteRewardedVideoEvent(string dataString)
		{
		}

		private void didDisplayRewardedVideoEvent(string location)
		{
		}

		private void didLoadInPlay(string location)
		{
		}

		private void didFailToLoadInPlayEvent(string dataString)
		{
		}

		private void didPauseClickForConfirmationEvent()
		{
		}

		private void willDisplayVideoEvent(string location)
		{
		}

		private void didCompleteAppStoreSheetFlowEvent(string empty)
		{
		}

		private static void doUnityPause(bool pause)
		{
		}

		public static bool isImpressionVisible()
		{
			return default;
		}
	}
}
