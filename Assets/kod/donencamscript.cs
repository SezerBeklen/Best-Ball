
using UnityEngine;

public class donencamscript : MonoBehaviour
{

    public int speed;
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
