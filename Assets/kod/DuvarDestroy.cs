using UnityEngine;

public class DuvarDestroy : MonoBehaviour
{
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ucurum")
        {
            Destroy(this.gameObject);
        }
    }
}
