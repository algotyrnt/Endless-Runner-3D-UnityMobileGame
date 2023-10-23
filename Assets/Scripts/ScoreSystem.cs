using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI scoreT;
    public TextMeshProUGUI cashT;

    public float scoreV;
    public float currentCashV;
    public float highScoreV;

    public float pointsPerSecond;

    Dead Dead;

    [SerializeField] private GameObject player;
    private PlayerMovement script;
    [SerializeField] private float speedincreaseMill = 500.0f;

    void Start()
    {
        currentCashV = 0.0f;
        PlayerPrefs.SetFloat("currentCash", currentCashV);
        scoreV = 0.0f;
        highScoreV = PlayerPrefs.GetFloat("highscore", highScoreV);
        Dead = GameObject.FindWithTag("GameManager").GetComponent<Dead>();
        
        script = player.GetComponent<PlayerMovement>();
    }


    void Update()
    {
        
            currentCashV = PlayerPrefs.GetFloat("currentCash", currentCashV);

            if (Dead.isDead == false)
            {
                scoreV += pointsPerSecond * Time.deltaTime;
            }

            if (scoreV > speedincreaseMill)
            {
                speedincreaseMill += speedincreaseMill;
                script.speedup();
            }

            if (scoreV > highScoreV)
            {
                highScoreV = scoreV;
                PlayerPrefs.SetFloat("highscore", highScoreV);
            }

            scoreT.text = "" + Mathf.Round(scoreV);
            cashT.text = "" + currentCashV;
        
    }
}
