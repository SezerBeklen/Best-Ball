using UnityEngine;

public class AnimationCoin : MonoBehaviour
{
    Animator Coin_Animm;
    public GameObject fx;
  
     void Start()
      {
        Coin_Animm = GetComponent<Animator>();
     }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Finish")
        {

            Coin_Animm.SetBool("CoinAnimator", true);
            fx.gameObject.SetActive(true);
        }
         
    }
}
