using UnityEngine;

public class BouncingFloor : MonoBehaviour
{
    public float Zıplama_Kuvveti = 20f;
    public AudioSource Jump_Sound;
    

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if (rb != null) 
        {
            Vector2 ZıplamaKuvveti = rb.velocity;
            ZıplamaKuvveti.y = Zıplama_Kuvveti;
            rb.velocity = ZıplamaKuvveti;
            Jump_Sound.Play();
            
        }


    }


}
