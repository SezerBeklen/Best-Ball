using UnityEngine;
using UnityEngine.SceneManagement;

public class startbuton : MonoBehaviour
{
    public void StartButon()
    {
        SceneManager.LoadScene("levelmenu");  
    }
}
