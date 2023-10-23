using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public GameObject pauseMenue;
    InterstitialAdsScript adsScript;

    private void Start()
    {
        adsScript = GameObject.FindWithTag("GameManager").GetComponent<InterstitialAdsScript>();
    }

    public void Pause()
    {
        pauseMenue.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenue.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Game()
    {
        adsScript.ShowInterstitialAd();
    }
}
