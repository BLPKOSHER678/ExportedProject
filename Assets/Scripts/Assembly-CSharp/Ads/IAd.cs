using System;

namespace Ads
{
    /// <summary>
    /// Compatibility shim for Apple's discontinued iAd banner service.
    /// The original ad implementation is intentionally disabled in modern Unity.
    /// </summary>
    public class IAd : Banner
    {
        public override void Show(Action<bool> callback)
        {
            // Do not attempt to load deprecated iAd banners.
            if (callback != null) callback(false);
        }

        public override void Hide()
        {
            // No ad to hide.
        }
    }
}
