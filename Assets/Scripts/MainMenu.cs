using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI cashT;
    public TextMeshProUGUI highScoreT;
    public TextMeshProUGUI levelT;

    public float cashV;
    public float highScoreV;

    public GameObject MainM;
    public GameObject MapM;
    public GameObject CharacterM;
    public GameObject LevelM;

    private float map;
    private float character;
    public float levelV;

    public GameObject dp;
    public GameObject rp;
    public GameObject wp;
    public GameObject bp;

    public GameObject DM;
    public GameObject NM;

    public GameObject LoadingScreen;

    InterstitialAdsScript adsScript;

    void Start()
    {
        highScoreV = PlayerPrefs.GetFloat("highscore", highScoreV);
        levelV = PlayerPrefs.GetFloat("level", levelV);

        highScoreT.text = "" + Mathf.Round(highScoreV);
        levelT.text = "" + (levelV + 1);

        MainM.SetActive(true);
        MapM.SetActive(false);
        CharacterM.SetActive(false);
        LevelM.SetActive(false);
        LoadingScreen.SetActive(false);

        character = PlayerPrefs.GetFloat("character", character);

        if (character == 1)
        {
            dp.SetActive(false);
            rp.SetActive(false);
            wp.SetActive(false);
            bp.SetActive(true);
        }
        else if (character == 2)
        {
            dp.SetActive(false);
            rp.SetActive(false);
            wp.SetActive(true);
            bp.SetActive(false);
        }
        else if (character == 3)
        {
            dp.SetActive(false);
            rp.SetActive(true);
            wp.SetActive(false);
            bp.SetActive(false);
        }
        else
        {
            dp.SetActive(true);
            rp.SetActive(false);
            wp.SetActive(false);
            bp.SetActive(false);
        }

        map = PlayerPrefs.GetFloat("map", map);
        
        if(map == 1)
        {
            NM.SetActive(true);
            DM.SetActive(false);
        }
        else
        {
            DM.SetActive(true);
            NM.SetActive(false);
        }

        adsScript = GameObject.FindWithTag("GameManager").GetComponent<InterstitialAdsScript>();
    }

    private void Update()
    {
        cashV = PlayerPrefs.GetFloat("cash", cashV);
        cashT.text = "" + Mathf.Round(cashV);
    }

    public void Map()
    {
        MapM.SetActive(true);
        MainM.SetActive(false);
    }
    public void Character()
    {
        CharacterM.SetActive(true);
        MainM.SetActive(false);
    }
    public void Level()
    {
        LevelM.SetActive(true);
        MainM.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Game()
    {
        adsScript.ShowInterstitialAd();
    }
    public void ExitM()
    {
        MapM.SetActive(false);
        CharacterM.SetActive(false);
        LevelM.SetActive(false);
        MainM.SetActive(true);
    }
    public void MapD()
    {
        map = 0;
        PlayerPrefs.SetFloat("map", map);
        DM.SetActive(true);
        NM.SetActive(false);
    }
    public void MapN()
    {
        map = 1;
        PlayerPrefs.SetFloat("map", map);
        NM.SetActive(true);
        DM.SetActive(false);
    }
    public void CharacterD()
    {
        character = 0;
        PlayerPrefs.SetFloat("character", character);
        dp.SetActive(true);
        rp.SetActive(false);
        wp.SetActive(false);
        bp.SetActive(false);
    }
    public void CharacterB()
    {
        character = 1;
        PlayerPrefs.SetFloat("character", character);
        dp.SetActive(false);
        rp.SetActive(false);
        wp.SetActive(false);
        bp.SetActive(true);
    }
    public void CharacterW()
    {
        character = 2;
        PlayerPrefs.SetFloat("character", character);
        dp.SetActive(false);
        rp.SetActive(false);
        wp.SetActive(true);
        bp.SetActive(false);
    }
    public void CharacterR()
    {
        character = 3;
        PlayerPrefs.SetFloat("character", character);
        dp.SetActive(false);
        rp.SetActive(true);
        wp.SetActive(false);
        bp.SetActive(false);
    }
}
