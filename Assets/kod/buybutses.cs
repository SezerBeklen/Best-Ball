
using UnityEngine;

public class buybutses : MonoBehaviour
{
public AudioSource ButttSesbuy;

    void Start()
    {
        ButttSesbuy = GetComponent<AudioSource>();
    }

    public void butonsesibuy()
    {
        ButttSesbuy.Play();
    }
}
