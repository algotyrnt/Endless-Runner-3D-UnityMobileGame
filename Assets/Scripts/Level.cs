using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public float cashV;
    public float highScoreV;
    public float levelV;

    public GameObject levelC1;
    public GameObject levelC2;
    public GameObject levelC3;
    public GameObject levelC4;


    void Start()
    {
        cashV = PlayerPrefs.GetFloat("cash", cashV);
        highScoreV = PlayerPrefs.GetFloat("highscore", highScoreV);
        levelV = PlayerPrefs.GetFloat("level", levelV);
    }
    void Update()
    {
            {
                if (levelV == 0)
                {
                    levelC1.SetActive(false);
                    levelC2.SetActive(false);
                    levelC3.SetActive(false);
                    levelC4.SetActive(false);

                    if (cashV >= 500 && highScoreV >= 500)
                    {
                        levelV = 1;
                        PlayerPrefs.SetFloat("level", levelV);
                        levelC1.SetActive(true);
                    }
                }
                else
                {
                    if (levelV == 1)
                    {
                        levelC1.SetActive(true);
                        levelC2.SetActive(false);
                        levelC3.SetActive(false);
                        levelC4.SetActive(false);

                        if (cashV >= 1000 && highScoreV >= 1000)
                        {
                            levelV = 2;
                            PlayerPrefs.SetFloat("level", levelV);
                            levelC2.SetActive(true);
                        }
                    }
                    else
                    {
                        if (levelV == 2)
                        {
                            levelC1.SetActive(true);
                            levelC2.SetActive(true);
                            levelC3.SetActive(false);
                            levelC4.SetActive(false);

                            if (cashV >= 5000 && highScoreV >= 5000)
                            {
                                levelV = 3;
                                PlayerPrefs.SetFloat("level", levelV);
                                levelC3.SetActive(true);
                            }
                        }
                        else
                        {
                            if (levelV == 3)
                            {
                                levelC1.SetActive(true);
                                levelC2.SetActive(true);
                                levelC3.SetActive(true);
                                levelC4.SetActive(false);

                                if (cashV >= 10000 && highScoreV >= 10000)
                                {
                                    levelV = 4;
                                    PlayerPrefs.SetFloat("level", levelV);
                                    levelC4.SetActive(true);
                                }
                            }
                            else
                            {
                                if (levelV == 4)
                                {
                                    levelC1.SetActive(true);
                                    levelC2.SetActive(true);
                                    levelC3.SetActive(true);
                                    levelC4.SetActive(true);
                                }
                                else
                                {
                                    levelV = 0;
                                    PlayerPrefs.SetFloat("level", levelV);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

