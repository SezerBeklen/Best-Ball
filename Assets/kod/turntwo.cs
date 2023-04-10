using UnityEngine;

public class turntwo : MonoBehaviour
{
    public float hiz;
    
    void FixedUpdate()
    {
        transform.Rotate(-1 * hiz, 0, 0);
    }
}
