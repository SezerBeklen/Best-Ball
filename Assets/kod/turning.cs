
using UnityEngine;

public class turning : MonoBehaviour
{
    public float hiz; 
    
    void FixedUpdate()
    {
        transform.Rotate(0, -1*hiz, 0);

    }
}
