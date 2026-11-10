using System.Collections;

namespace ChartboostSDK
{
	public sealed class CBLocation
	{
		private readonly string name;

		private static Hashtable map;

		public static readonly CBLocation Default;

		public static readonly CBLocation Startup;

		public static readonly CBLocation HomeScreen;

		public static readonly CBLocation MainMenu;

		public static readonly CBLocation GameScreen;

		public static readonly CBLocation Achievements;

		public static readonly CBLocation Quests;

		public static readonly CBLocation Pause;

		public static readonly CBLocation LevelStart;

		public static readonly CBLocation LevelComplete;

		public static readonly CBLocation TurnComplete;

		public static readonly CBLocation IAPStore;

		public static readonly CBLocation ItemStore;

		public static readonly CBLocation GameOver;

		public static readonly CBLocation LeaderBoard;

		public static readonly CBLocation Settings;

		public static readonly CBLocation Quit;

		private CBLocation(string name)
		{
		}

		public override string ToString()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static CBLocation locationFromName(string name)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}
}
