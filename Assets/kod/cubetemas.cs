
using UnityEngine;

public class cubetemas : MonoBehaviour
{
    public GameObject toptetik_küp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            toptetik_küp.SetActive(true);
        }
    }
}
