using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUp : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float ForceSpeed;//bunu oluþturma sebebi eksi yönde hýz oluþturmak için referans 
    public bool timer;

    public float time;//zamanýmýz
    public float interval;//aralýðýmýz bu iki deðiþkeni platformun beklemesi ve sonrasýndan devam etmesi için oluþturduk
    void Start()
    {
        ForceSpeed = speed;
    }


    void Update()
    {
        rb.velocity = Vector3.up * ForceSpeed;

        if (timer)
        {
            time += Time.deltaTime; // burda time ýn nasýl artmasý gerektiðini söyledik zamana göre artsýn ki interval deðerine eþit gelene kadar artsýn 

            if (time > interval)
            {

                if (ForceSpeed > 0)
                {
                    ForceSpeed = -speed;
                    timer = false;
                    time = 0; //time ý sýfýrlamazsak hep ayný deðer olacaðýndan tekrarlanmaz bekleme iþlemi.
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
