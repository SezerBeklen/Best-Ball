
using UnityEngine;

public class OpenCloseSoundTwo : MonoBehaviour
{
    public GameObject SesAcik, SesKapali;
    public AudioSource BUTON_SES;
    void Start()
    {
        //PlayerPrefs.SetInt("sesdurum2", 1);
    }


    void Update()
    {
        if (PlayerPrefs.GetInt("sesdurum2") == 0)
        {
            SesAcik.SetActive(true);
            SesKapali.SetActive(false);
        }
        else
        {
            SesAcik.SetActive(false);
            SesKapali.SetActive(true);
        }

    }
    public void ses_durum2(string durumnew)
    {
        if (durumnew == "open")
        {
            SesAcik.SetActive(false);
            SesKapali.SetActive(true);
            BUTON_SES.Play();

            PlayerPrefs.SetInt("sesdurum2", 1);
        }
        else if (durumnew == "close")
        {
            SesAcik.SetActive(true);
            SesKapali.SetActive(false);
            PlayerPrefs.SetInt("sesdurum2", 0);
            BUTON_SES.Play();
        }


    }
}
