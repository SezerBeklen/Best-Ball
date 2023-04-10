using System.Collections;
using UnityEngine;

public class beklemebıtıs : MonoBehaviour
{
    public pauseMenu Level_comp;
    public void bıtısbek()
    {
        StartCoroutine(nextlevel());
    }
    
    
    
    IEnumerator nextlevel()
    {
        yield return new WaitForSeconds(5f);
        Level_comp.LevelComplet();

        // SceneManager.LoadScene(level);
    }
}
