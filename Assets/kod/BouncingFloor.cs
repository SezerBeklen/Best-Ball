using UnityEngine;

public class BouncingFloor : MonoBehaviour
{
    public float Zýplama_Kuvveti = 20f;
    public AudioSource Jump_Sound;
    

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if (rb != null) 
        {
            Vector2 ZýplamaKuvveti = rb.velocity;
            ZýplamaKuvveti.y = Zýplama_Kuvveti;
            rb.velocity = ZýplamaKuvveti;
            Jump_Sound.Play();
            
        }


    }


}
