using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class ADSManger : MonoBehaviour {

	// Use this for initialization
	void Start () {
        RequestBanner();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-1892444888800550/6156573627";
#elif UNITY_IPHONE
        string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.TopRight);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
    }

}
