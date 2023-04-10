using UnityEngine;

public class SoundManageer : MonoBehaviour
{

    AudioSource ses_kontrol;
    void Start()
    {

        ses_kontrol = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("sesdurum") == 0)
        {
            ses_kontrol.mute = false;
        }
        else
        {
            ses_kontrol.mute = true;
        }
         
    }

   



}
