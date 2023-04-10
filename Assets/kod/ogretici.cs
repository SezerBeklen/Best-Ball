using System.Collections;
using UnityEngine;

public class ogretici : MonoBehaviour
{
    public GameObject Ogretici_Anim;
    public GameObject PauseButon;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
           Ogretici_Anim.SetActive(true);
            PauseButon.SetActive(false);
            StartCoroutine(beklemeSuresi());
        }   
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Ogretici_Anim.SetActive(false);
            gameObject.SetActive(false);
        }
    }
    IEnumerator beklemeSuresi()
    {
      yield return new WaitForSeconds(4);
      Ogretici_Anim.SetActive(false);
        PauseButon.SetActive(true);
    }   
    
   
    
}
