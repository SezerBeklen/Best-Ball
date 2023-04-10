
using UnityEngine;
using UnityEngine.UI;

public class GoldScore : MonoBehaviour
{
    public int Score;
    public Text Gold_Score;
    public AudioSource CoinSound;
    
  
   public void Start()
    {
         
        Score = PlayerPrefs.GetInt("Score");
        Gold_Score.text = Score.ToString();
    }
    void OnTriggerEnter(Collider gold)
    {

        if (gold.gameObject.tag == "Gold")
        {
            
            Score +=10;
            CoinSound.Play();
            PlayerPrefs.SetInt("Score", Score);
            Destroy(gold.gameObject,1f);
           
            Gold_Score.text = Score.ToString();
        }
    }


    public void satinAlBut()
    {
        Gold_Score.text = PlayerPrefs.GetInt("Score").ToString();
    }

}
