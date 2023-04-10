using System.Collections;
using UnityEngine;


public class Menedzser : MonoBehaviour
{
    public pauseMenu Game_over;
   
    public void UjSzeneKesobb()
    {
        StartCoroutine(bekleme());
    }

    IEnumerator bekleme()
    {

        yield return new WaitForSeconds(2);

        Game_over.GameOver();
        
    }

}
