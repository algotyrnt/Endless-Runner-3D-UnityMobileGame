
using UnityEngine;

public class GoldScore : MonoBehaviour
{
    public float cashV;
    public float currentCashV;

    void OnTriggerEnter()
    {
        cashV = PlayerPrefs.GetFloat("cash", cashV);
        currentCashV = PlayerPrefs.GetFloat("currentCash", currentCashV);

        cashV += 15;
        currentCashV += 15;

        PlayerPrefs.SetFloat("cash", cashV);
        PlayerPrefs.SetFloat("currentCash", currentCashV);

        gameObject.SetActive(false);
    }
}


