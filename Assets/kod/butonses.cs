
using UnityEngine;

public class butonses : MonoBehaviour
{
    public AudioSource ButttSes;
   
   
    void Start()
    {
     
        ButttSes= GetComponent<AudioSource>();
        
        
    }

    public void butonsesi()
    {
        ButttSes.Play();
    }
     
}

    

