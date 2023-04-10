using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject pausescreen;
    public GameObject pauseButon;
    public GameObject settýngscreen;
    public GameObject FinishMUsic;
    public AudioSource ButonSes;

    public GameObject GameOverScreen;
    public GameObject LevelCompletedScreen;
    public GameObject Progres_bar;
    //public bitis bgmusic;

    GecisReklam gecisReach;
    odullureklam odulluReach;

    public void Start()
    {
        gecisReach = GetComponent<GecisReklam>();
        odulluReach = GetComponent<odullureklam>();
    }

    public void ButPause()
    {
        StartCoroutine(PauseBekleAnim());
        pausescreen.SetActive(true);
       // Time.timeScale = 1;//oyunun durup durmamasýný saðlýyor 0 olunca durur 1 olunca çalýþýr.
        FinishMUsic.SetActive(false);
        pauseButon.SetActive(false);
        Progres_bar.SetActive(false);
        
        ButonSes.Play();

    }

    public void homeicon()
    {

        SceneManager.LoadScene("menu");
        Time.timeScale = 1;
        ButonSes.Play();
    }

    public void rasumeicon()
    {
        Time.timeScale = 1;
        pausescreen.SetActive(false);
        
        pauseButon.SetActive(true);
        Progres_bar.SetActive(true);
        ButonSes.Play();
       
    }

    public void settýngsýcon()
    {
        pausescreen.SetActive(false);
        settýngscreen.SetActive(true);
        pauseButon.SetActive(false);
        ButonSes.Play();
    }
    public void settBack()
    {
        settýngscreen.SetActive(false);
        pausescreen.SetActive(true);
        ButonSes.Play();
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        Progres_bar.SetActive(false);
        
    } 
    public void LevelComplet()
    {
        LevelCompletedScreen.SetActive(true);
        Progres_bar.SetActive(false);
        StartCoroutine(FinishDurdurma());
    }

    public void NextLevelFinish()
    {
        if (SceneManager.GetActiveScene().buildIndex > PlayerPrefs.GetInt("LevelCount"))
        {
            PlayerPrefs.SetInt("LevelCount", SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Debug.Log("kaydetme çalýþtýrmadý");
        }
        gecisReach.GecisVideo_Reklam_Goster();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }

    public void NextlevelAdds()
    {
        odulluReach.Odullu_Reklam_Show();
        if (SceneManager.GetActiveScene().buildIndex > PlayerPrefs.GetInt("LevelCount"))
        {
            PlayerPrefs.SetInt("LevelCount", SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Debug.Log("kaydetme çalýþtýrmadý");
        }

    }
    public void NoThanks()
    {

        StartCoroutine(GecisReklamBekle());
        
    }
    public IEnumerator PauseBekleAnim()
    {
        yield return new WaitForSeconds(0f);
        Time.timeScale = 0;
    }

    public IEnumerator FinishDurdurma()
    {
        yield return new WaitForSeconds(2);
        Time.timeScale = 0;
        //bgmusic.BgSound.SetActive(true);
    }
   
   IEnumerator GecisReklamBekle()
    {
        yield return new WaitForSeconds(1f);
        gecisReach.Gecis_Reklam_Goster();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
