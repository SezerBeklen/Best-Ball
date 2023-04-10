using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelElevenAnim : MonoBehaviour
{
    public Animator NightAmi;

    public void Start()
    {
        
        NightAmi = GetComponent <Animator>();

        NightAmi.SetBool("NightAnim", true);

        
    }

   
}
