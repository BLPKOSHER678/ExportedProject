using System;
using UnityEngine;

namespace Ads
{
	public abstract class Banner : MonoBehaviour
	{
		public bool Enabled;

		public int Priority;

		public abstract void Show(Action<bool> callback);

		public abstract void Hide();
	}
}
