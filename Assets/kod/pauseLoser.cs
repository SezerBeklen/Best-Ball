
using UnityEngine;

public class pauseLoser : MonoBehaviour
{
    public GameObject Pausebuton;
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Finish")
        {

            Pausebuton.SetActive(false);
        }

    }
}
