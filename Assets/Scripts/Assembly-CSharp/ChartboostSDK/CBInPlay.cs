using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace ChartboostSDK
{
	public class CBInPlay
	{
		public Texture2D appIcon;

		public string appName;

		private IntPtr inPlayUniqueId;

		public CBInPlay(IntPtr uniqueId)
		{
		}

		[DllImport("__Internal")]
		private static extern void _chartBoostInPlayClick(IntPtr uniqueID);

		[DllImport("__Internal")]
		private static extern void _chartBoostInPlayShow(IntPtr uniqueID);

		[DllImport("__Internal")]
		private static extern IntPtr _chartBoostInPlayGetAppIcon(IntPtr uniqueID);

		[DllImport("__Internal")]
		private static extern int _chartBoostInPlayGetAppIconSize(IntPtr uniqueID);

		[DllImport("__Internal")]
		private static extern string _chartBoostInPlayGetAppName(IntPtr uniqueID);

		[DllImport("__Internal")]
		private static extern void _chartBoostFreeInPlayObject(IntPtr uniqueID);

		public void show()
		{
		}

		public void click()
		{
		}

		~CBInPlay()
		{
		}
	}
}
