
using UnityEngine;

public class cubetemas : MonoBehaviour
{
    public GameObject toptetik_k�p;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            toptetik_k�p.SetActive(true);
        }
    }
}
