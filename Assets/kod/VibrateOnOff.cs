
using UnityEngine;

public class VibrateOnOff : MonoBehaviour
{
    public GameObject VibrateOpened, VibrateClosed;
    public AudioSource BUTON_SES;
    void Start()
    {
        //PlayerPrefs.SetInt("VibrateOnOff", 1);
    }


    void Update()
    {
        if (PlayerPrefs.GetInt("VibrateOnOff") == 0)
        {
            VibrateOpened.SetActive(true);
            VibrateClosed.SetActive(false);
        }
        else
        {
            VibrateOpened.SetActive(false);
            VibrateClosed.SetActive(true);
        }

    }
    public void VibrateControl(string VibrateOffOn)
    {
        if (VibrateOffOn == "Open")
        {
            VibrateOpened.SetActive(false);
            VibrateClosed.SetActive(true);
            BUTON_SES.Play();

            PlayerPrefs.SetInt("VibrateOnOff", 1);
        }
        else if (VibrateOffOn == "Close")
        {
            VibrateOpened.SetActive(true);
            VibrateClosed.SetActive(false);
            PlayerPrefs.SetInt("VibrateOnOff", 0);
            BUTON_SES.Play();
        }


    }
}
