using UnityEngine;
public class yanma : MonoBehaviour
{
    public GameObject kýrýlanobje;
    public GameObject anaanobje;
    public Menedzser menedzser;
    public GameObject yanmases;
    public GameObject PauseButonn;
    public GameObject Progress;
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            kýrýlanobje.SetActive(true);
            anaanobje.SetActive(false);

            kýrýlanobje.transform.parent = null;
            gameObject.SetActive(false);
            yanmases.SetActive(true);
            if (PlayerPrefs.GetInt("VibrateOnOff") == 0)
            {
                Týtre();
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
    public void Týtre()
    {
        Handheld.Vibrate();
    }


}




