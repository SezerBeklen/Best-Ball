using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class odullureklam : MonoBehaviour
{
    public RewardedAd Odullu_Reklam;
    string ÖdüllüRekalmÝD= " ";
    string ReklamÝd;
    public void Start()
    {
        Reward_Ad_Request();
    }

    public void Reward_Ad_Request()
    {
        #if UNITY_ANDROID
                ReklamÝd = ÖdüllüRekalmÝD;
        #elif UNITY_IPHONE
                ReklamÝd="";
        #else
                ReklamÝd = "tanýmsýz";
        #endif
        
        
        Odullu_Reklam = new RewardedAd(ReklamÝd);
        Odullu_Reklam.OnUserEarnedReward += OdulKazanýldý;
        
        AdRequest request = new AdRequest.Builder().Build();
        Odullu_Reklam.LoadAd(request);
    }
    public void OdulKazanýldý(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Odullu_Reklam_Show()
    {
        if (Odullu_Reklam.IsLoaded())
        {
            Odullu_Reklam.Show();
        }
       
    }
   
}
