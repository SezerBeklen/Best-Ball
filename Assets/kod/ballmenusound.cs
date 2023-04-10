using UnityEngine;

public class ballmenusound : MonoBehaviour
{
    AudioSource Ballmenuses;
    void Start()
    {
        Ballmenuses = GetComponent<AudioSource>();
         
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("sesdurum") == 0)
        {
            Ballmenuses.mute = false;
        }
        else
        {
            Ballmenuses.mute = true;
        }

    }


}
