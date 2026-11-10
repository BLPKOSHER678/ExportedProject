using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace Ads
{
	public class IAd : Banner
	{
		private ADBannerView _banner;

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void CreateBanner()
		{
		}

		private void OnBannerClicked()
		{
		}

		public override void Show(Action<bool> callback)
		{
		}

		public override void Hide()
		{
		}

		[DebuggerHidden]
		private IEnumerator WaitBannerLoad(Action<bool> callback)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}
}
