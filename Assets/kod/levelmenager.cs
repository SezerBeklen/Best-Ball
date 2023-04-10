using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelmenager : MonoBehaviour
{
    public int Level_Count;
    public Button[] LevelsButtons;
    public AudioSource LevelBut_Ses;
    
    public void Start()
    {
        
        //PlayerPrefs.DeleteKey("LevelCount");
        LockSystem();
    }
    public void OpenLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
        LevelBut_Ses.Play();
    }

    public void LockSystem()
    {
        Level_Count = PlayerPrefs.GetInt("LevelCount");
        

        for (int i = 0; i < LevelsButtons.Length; i++)
        {
           
            if (Level_Count + 1 >= int.Parse(LevelsButtons[i].name))
            {
                LevelsButtons[i].interactable = true;
            }
            else
            {
                LevelsButtons[i].interactable = false;
            }
        }
       


    }





}
