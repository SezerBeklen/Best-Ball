using UnityEngine;
public class yanma : MonoBehaviour
{
    public GameObject k�r�lanobje;
    public GameObject anaanobje;
    public Menedzser menedzser;
    public GameObject yanmases;
    public GameObject PauseButonn;
    public GameObject Progress;
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            k�r�lanobje.SetActive(true);
            anaanobje.SetActive(false);

            k�r�lanobje.transform.parent = null;
            gameObject.SetActive(false);
            yanmases.SetActive(true);
            if (PlayerPrefs.GetInt("VibrateOnOff") == 0)
            {
                T�tre();
            }
            else
            {
                Debug.Log("titremedi");
            }
            menedzser.UjSzeneKesobb();
            
            PauseButonn.SetActive(false);
            Progress.SetActive(false);
        }
    }
    public void T�tre()
    {
        Handheld.Vibrate();
    }


}




