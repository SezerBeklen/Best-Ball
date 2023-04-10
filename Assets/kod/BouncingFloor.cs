using UnityEngine;

public class BouncingFloor : MonoBehaviour
{
    public float Z�plama_Kuvveti = 20f;
    public AudioSource Jump_Sound;
    

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if (rb != null) 
        {
            Vector2 Z�plamaKuvveti = rb.velocity;
            Z�plamaKuvveti.y = Z�plama_Kuvveti;
            rb.velocity = Z�plamaKuvveti;
            Jump_Sound.Play();
            
        }


    }


}
