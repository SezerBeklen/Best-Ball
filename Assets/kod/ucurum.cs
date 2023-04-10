
using UnityEngine;


public class ucurum : MonoBehaviour
{
    public pauseMenu Game_over;
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
           // SceneManager.LoadScene("1");
           // PlayerPrefs.DeleteKey("Score");
            Game_over.GameOver();
        }
        
       
    }

   
}
