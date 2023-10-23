using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InterstitialAdsScript : MonoBehaviour, IUnityAdsListener
{
    string gameId = "4158326";
    bool testMode = false;

    public GameObject LoadingScreen;
    public Slider LoadingSlider;
    public Text progressText;
    public int scenIndex;

    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);
    }
    
    public void ShowInterstitialAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("video");
        }
        else
        {
            LoadLevel(1);
        }
    }

    public void OnUnityAdsDidFinish(string surfacingId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            LoadLevel(1);
        }
        else if (showResult == ShowResult.Skipped)
        {
            LoadLevel(1);
        }
        else if (showResult == ShowResult.Failed)
        {
            LoadLevel(1);
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        
    }

    public void OnUnityAdsDidError(string message)
    {
        
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        
    }

    public void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int seceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(seceneIndex);

        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            LoadingSlider.value = progress;
            progressText.text = Mathf.Round(progress) * 100f + "%";

           yield return null;
        }
    }
}