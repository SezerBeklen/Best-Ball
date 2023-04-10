using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballselector : MonoBehaviour
{
    public int CurrentBallindex;
    
    public GameObject[] Balls;
     
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        CurrentBallindex = PlayerPrefs.GetInt("SelectedBall", 0);
        foreach (GameObject ball in Balls)
            ball.SetActive(false);
        
        Balls[CurrentBallindex].SetActive(true);

      
    }

}
