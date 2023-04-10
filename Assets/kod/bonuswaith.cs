using UnityEngine;

public class bonuswaith : MonoBehaviour
{
    public GameObject bonusbutsil;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
            bonusbutsil.SetActive(false);
    }

}
