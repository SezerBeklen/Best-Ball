using UnityEngine;


public class bitis : MonoBehaviour
{
    public GameObject DonenKamera;
    public GameObject AlkisSound;
    public GameObject BgSound;
    public GameObject finisheffect;
    public GameObject finisheffectother;
    public beklemebýtýs býtýswaith;
    public GameObject pauseButon;
    public GameObject UpDownButon;
   // public GameObject LeftrightButon;

    private void OnCollisionEnter(Collision c)
    {
 
        if (c.gameObject.tag == "Finish")
        {
            DonenKamera.SetActive(true);
            pauseButon.SetActive(false);
            // UpDownButon.SetActive(false);
            // LeftrightButon.SetActive(false);
 
        }
       
        
        if (c.gameObject.tag == "Finish")
        {
            AlkisSound.SetActive(true);
        } 
        
      
        if (c.gameObject.tag == "Finish")
        {
            BgSound.SetActive(false);
        }
      
        
        if (c.gameObject.tag == "Finish")
        {
            finisheffect.SetActive(true);
        }
       
        
        if (c.gameObject.tag == "Finish")
        {
            finisheffectother.SetActive(true);
        }
        
        
        if (c.gameObject.tag == "Finish")
        {
            býtýswaith.býtýsbek();

        } 

    }

    


}
