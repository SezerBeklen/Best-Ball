using UnityEngine;

public class EffectSoundMenager : MonoBehaviour
{
    public AudioSource SesOne;
    public AudioSource SesTwo;
    public AudioSource SesThree;
    public AudioSource CoinSoundd;
    public AudioSource BouncingSound;
    
 
    void Update()
    {
        if (PlayerPrefs.GetInt("sesdurum2") == 0)
        {
            SesOne.mute = false;
        }
        else
        {
            SesOne.mute = true;
        }
        
        if (PlayerPrefs.GetInt("sesdurum2") == 0)
        {
            SesTwo.mute = false;
        }
        else
        {
            SesTwo.mute = true;
        }
      
        
        if (PlayerPrefs.GetInt("sesdurum2") == 0)
        {
            SesThree.mute = false;
        }
        else
        {
            SesThree.mute = true;
        }
    
      
     
        if (PlayerPrefs.GetInt("sesdurum2") == 0)
        {
            CoinSoundd.mute = false;
        }
        else
        {
            CoinSoundd.mute = true;
        }
     
        
      
        if (PlayerPrefs.GetInt("sesdurum2") == 0)
        {
            BouncingSound.mute = false;
        }
        else
        {
            BouncingSound.mute = true;
        }
     
       
    
     










    }
}
