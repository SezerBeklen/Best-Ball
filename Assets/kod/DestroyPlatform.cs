using System.Collections;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
     Animator DestroyAnim;



    private void Start()
    {
        DestroyAnim = GetComponent<Animator>();
    }
   
    public void OnCollisionEnter(Collision Ncolor)
    {
        if (Ncolor.gameObject.tag == "Finish")
        {
            StartCoroutine(DestroyPlatformWaith());
            
            
        }
    }

  IEnumerator DestroyPlatformWaith()
    {
        yield return new WaitForSeconds(0.5f);
        DestroyAnim.SetBool("DestroyAnim", true);
        Destroy(gameObject, 1.4f);
    }
}
