using UnityEngine;
using GoogleMobileAds.Api;

public class GecisReklam : MonoBehaviour
{
    public InterstitialAd gecis;
    public InterstitialAd gecisVideo;
    string interstitial_ad_ID = " ";
    string interstitial_ad_IDvideo = " ";
    string Reklam›D;
    string Reklam›Dvideo;




    public void Start()
    {
        ›nterstitialAdRequest();
        ›nterstitialdVideoRequest();
    }
    public void ›nterstitialAdRequest()
    {
        #if UNITY_ANDROID
                Reklam›D = interstitial_ad_ID;
        #elif UNITY_IPHONE
                Reklam›D="";
        #else
                Reklam›D = "tan˝ms˝z";
        #endif
        gecis = new InterstitialAd(Reklam›D);
        AdRequest request = new AdRequest.Builder().Build();
        gecis.LoadAd(request);

    }
    public void ›nterstitialdVideoRequest()
    {
#if UNITY_ANDROID
        Reklam›Dvideo = interstitial_ad_IDvideo;
#elif UNITY_IPHONE
                            Reklam›Dvideo="";
#else
                            Reklam›Dvideo = "tan˝ms˝z";
#endif
        gecisVideo = new InterstitialAd(Reklam›Dvideo);
        AdRequest requestt = new AdRequest.Builder().Build();
        gecisVideo.LoadAd(requestt);
    }
    public void Gecis_Reklam_Goster()
    {
        if (gecis.IsLoaded())
        {
            gecis.Show();
        }
        else
        {
            ›nterstitialAdRequest();
        }
    }
    
    public void GecisVideo_Reklam_Goster()
    {
        if (gecisVideo.IsLoaded())
        {
            gecisVideo.Show();
        }
        else
        {
            ›nterstitialdVideoRequest();
        }
    }


   

}
