using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUp : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float ForceSpeed;//bunu olu�turma sebebi eksi y�nde h�z olu�turmak i�in referans 
    public bool timer;

    public float time;//zaman�m�z
    public float interval;//aral���m�z bu iki de�i�keni platformun beklemesi ve sonras�ndan devam etmesi i�in olu�turduk
    void Start()
    {
        ForceSpeed = speed;
    }


    void Update()
    {
        rb.velocity = Vector3.up * ForceSpeed;

        if (timer)
        {
            time += Time.deltaTime; // burda time �n nas�l artmas� gerekti�ini s�yledik zamana g�re arts�n ki interval de�erine e�it gelene kadar arts�n 

            if (time > interval)
            {

                if (ForceSpeed > 0)
                {
                    ForceSpeed = -speed;
                    timer = false;
                    time = 0; //time � s�f�rlamazsak hep ayn� de�er olaca��ndan tekrarlanmaz bekleme i�lemi.
                }
                else if (ForceSpeed < 0)
                {
                    ForceSpeed = speed;
                    timer = false;
                    time = 0;
                }
            }
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            timer = true;
        }
    }
}
