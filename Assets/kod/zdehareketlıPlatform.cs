using UnityEngine;

public class zdehareketlıPlatform: MonoBehaviour
{
    public Rigidbody rbb;
    public float speedd;
    public float ForceSpeedd;//bunu oluşturma sebebi eksi yönde hız oluşturmak için referans 
    public bool timerr;

    public float timee;//zamanımız
    public float intervall;//aralığımız bu iki değişkeni platformun beklemesi ve sonrasından devam etmesi için oluşturduk
    void Start()
    {
        ForceSpeedd = speedd;
    }

    void Update()
    {
        rbb.velocity = Vector3.forward * ForceSpeedd;

        if (timerr)
        {
            timee += Time.deltaTime; // burda time ın nasıl artması gerektiğini söyledik zamana göre artsın ki interval değerine eşit gelene kadar artsın 

            if (timee > intervall)
            {

                if (ForceSpeedd > 0)
                {
                    ForceSpeedd = -speedd;
                    timerr = false;
                    timee = 0; //time ı sıfırlamazsak hep aynı değer olacağından tekrarlanmaz bekleme işlemi.
                }
                else if (ForceSpeedd < 0)
                {
                    ForceSpeedd = speedd;
                    timerr = false;
                    timee = 0;
                }
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            timerr = true;
        }
    }
}