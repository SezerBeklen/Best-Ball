using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class leveltext : MonoBehaviour
{
    public Text Levelt_text;
    void Start()
    {
        Levelt_text.text = "Level "+ SceneManager.GetActiveScene().name;
    }

    
   
}
