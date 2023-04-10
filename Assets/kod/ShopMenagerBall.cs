using UnityEngine;
using UnityEngine.UI;

public class ShopMenagerBall : MonoBehaviour
{
    public int CurrentBallindex;
    public GameObject[] BallsModels;
    protected BallsBuy b;
    public BallsBuy[] toplar;
    public Button buyButton;
     
    void Start()
    {
        
        //PlayerPrefs.DeleteAll();
        foreach (BallsBuy top in toplar)
        {
            if (top.price == 0)
                top.isUnlocked = true;
            else
                top.isUnlocked = PlayerPrefs.GetInt(top.name, 0) == 0 ? false : true;
        }
        
        CurrentBallindex = PlayerPrefs.GetInt("SelectedBall");
        
        foreach (GameObject ball in BallsModels)
            ball.SetActive(false);
        BallsModels[CurrentBallindex].SetActive(true);
    }
    void Update()
    {
        UpdateUI();

    }

    public void UnlockBall()
    {
        b = toplar[CurrentBallindex];
        PlayerPrefs.SetInt(b.name, 1);
        PlayerPrefs.SetInt("SelectedBall", CurrentBallindex);
        b.isUnlocked = true;
        
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - b.price);
        
    }
    public void ChangeNextBall()
    {

        BallsModels[CurrentBallindex].SetActive(false);
        CurrentBallindex++;
        if (CurrentBallindex == BallsModels.Length)
            CurrentBallindex = 0;
        BallsModels[CurrentBallindex].SetActive(true);

         b = toplar[CurrentBallindex];
        if (!b.isUnlocked)
            return;

        PlayerPrefs.SetInt("SelectedBall", CurrentBallindex);
    }
    public void ChangePreviousBall()
    {

        BallsModels[CurrentBallindex].SetActive(false);
        CurrentBallindex--;
        if (CurrentBallindex == -1)
            CurrentBallindex = BallsModels.Length-1;
        BallsModels[CurrentBallindex].SetActive(true);

        b = toplar[CurrentBallindex];
        if (!b.isUnlocked)
            return;

        PlayerPrefs.SetInt("SelectedBall", CurrentBallindex);
    }


    private void UpdateUI()
    {
        b = toplar[CurrentBallindex];
        
        if (b.isUnlocked)
        {
            buyButton.gameObject.SetActive(false);
            

        }
        else
        {
            buyButton.gameObject.SetActive(true);
            buyButton.GetComponentInChildren<Text>().text = b.price.ToString();

            if (b.price <= PlayerPrefs.GetInt("Score"))
            {
                buyButton.interactable = true;
            }
            else
            {
                buyButton.interactable = false;
            }
        }

    }
}
