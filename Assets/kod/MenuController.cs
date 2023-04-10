
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    [Header("UIPages")]
    public GameObject SettingsScreen;
    public GameObject CreditsScreen;
    public GameObject MainScreen;
    public AudioSource ButSes;
    private BannerReklam Bannerreach;

    private void Start()
    {
        ButSes = GetComponent<AudioSource>();
        Bannerreach = GetComponent<BannerReklam>();
    }
    public void StartGame()
    {
        Bannerreach.BannerRemove();
        SceneManager.LoadScene("BallMenu");
        ButSes.Play();
    }
    public void Settings()
    {
        MainScreen.SetActive(false);
        SettingsScreen.SetActive(true);
        ButSes.Play();
    }
    public void set2menu()
    {
        MainScreen.SetActive(true);
        SettingsScreen.SetActive(false);
        ButSes.Play();
    }
    public void Credits()
    {
        MainScreen.SetActive(false);
        CreditsScreen.SetActive(true);
        ButSes.Play();
    }
    public void cre2menu()
    {
        MainScreen.SetActive(true);
        CreditsScreen.SetActive(false);
        ButSes.Play();
    }
    public void Exýt()
    {
        Application.Quit();
        ButSes.Play();
    }

}
