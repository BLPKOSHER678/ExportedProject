using UnityEngine;

namespace ChartboostSDK
{
	public class CBSettings : ScriptableObject
	{
		private const string cbSettingsAssetName = "ChartboostSettings";

		private const string cbSettingsPath = "Chartboost/Resources";

		private const string cbSettingsAssetExtension = ".asset";

		private const string iOSExampleAppIDLabel = "CB_IOS_APP_ID";

		private const string iOSExampleAppSignatureLabel = "CB_IOS_APP_SIGNATURE";

		private const string iOSExampleAppID = "4f21c409cd1cb2fb7000001b";

		private const string iOSExampleAppSignature = "92e2de2fd7070327bdeb54c15a5295309c6fcd2d";

		private const string androidExampleAppIDLabel = "CB_ANDROID_APP_ID";

		private const string androidExampleAppSignatureLabel = "CB_ANDROID_APP_SIGNATURE";

		private const string androidExampleAppID = "4f7b433509b6025804000002";

		private const string androidExampleAppSignature = "dd2d41b69ac01b80f443f5b6cf06096d457f82bd";

		private const string amazonExampleAppIDLabel = "CB_AMAZON_APP_ID";

		private const string amazonExampleAppSignatureLabel = "CB_AMAZON_APP_SIGNATURE";

		private const string amazonExampleAppID = "542ca35d1873da32dbc90488";

		private const string amazonExampleAppSignature = "90654a340386c9fb8de33315e4210d7c09989c43";

		private const string exampleCredentialsWarning = "CHARTBOOST: You are using a Chartboost example App ID or App Signature! Go to the Chartboost dashboard and replace these with an App ID & App Signature from your account! If you need help, email us: support@chartboost.com";

		private static bool credentialsWarning;

		private static CBSettings instance;

		[SerializeField]
		public string iOSAppId;

		[SerializeField]
		public string iOSAppSecret;

		[SerializeField]
		public string androidAppId;

		[SerializeField]
		public string androidAppSecret;

		[SerializeField]
		public string amazonAppId;

		[SerializeField]
		public string amazonAppSecret;

		[SerializeField]
		public bool isLoggingEnabled;

		[SerializeField]
		public string[] androidPlatformLabels;

		[SerializeField]
		public int selectedAndroidPlatformIndex;

		private static CBSettings Instance
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public int SelectedAndroidPlatformIndex
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public string[] AndroidPlatformLabels
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public void SetAndroidPlatformIndex(int index)
		{
		}

		public void SetIOSAppId(string id)
		{
		}

		public static string getIOSAppId()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public void SetIOSAppSecret(string secret)
		{
		}

		public static string getIOSAppSecret()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public void SetAndroidAppId(string id)
		{
		}

		public static string getAndroidAppId()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public void SetAndroidAppSecret(string secret)
		{
		}

		public static string getAndroidAppSecret()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public void SetAmazonAppId(string id)
		{
		}

		public static string getAmazonAppId()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public void SetAmazonAppSecret(string secret)
		{
		}

		public static string getAmazonAppSecret()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static string getSelectAndroidAppId()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static string getSelectAndroidAppSecret()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static void enableLogging(bool enabled)
		{
		}

		public static bool isLogging()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static void DirtyEditor()
		{
		}

		private static void CredentialsWarning()
		{
		}
	}
}
