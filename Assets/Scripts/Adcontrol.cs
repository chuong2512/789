using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

// Example script showing how to invoke the Google Mobile Ads Unity plugin.
public class Adcontrol : MonoBehaviour
{
    public bool forcoin;
    public static Adcontrol instace;
    public string GameId = "3988497";
    private bool testmode = false;
    public string videoAd = "video";
    public string banner = "banner";
    public string reward = "rewardedVideo";
    private void Awake()
    {
        instace = this;
    }

// Adcontrol.instace.showAd();


    // Start is called before the first frame update
    void Start()
    {

      
        showBanner();


    }


    public void showBanner()
    {

        StartCoroutine(ShowBannerWhenInitialized());
      
    }

    public void showAd()
    {
      
    }


    IEnumerator ShowBannerWhenInitialized()
    {
            yield return new WaitForSeconds(0.5f);
    }

    public void hideBanner()
    {
    }


    public void ShowRewardedVideo()
    {
     
    }

    // Implement IUnityAdsListener interface methods:
}