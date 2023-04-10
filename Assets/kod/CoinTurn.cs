
using UnityEngine;

public class CoinTurn : MonoBehaviour
{
   
    public int speed;
    void FixedUpdate()
    {
        transform.Rotate(0, 1 * speed, 0);
    }

    
}
