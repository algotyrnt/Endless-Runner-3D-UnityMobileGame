using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockable : MonoBehaviour
{
    public float cashValue;
    public GameObject rp;
    public GameObject wp;
    public GameObject bp;

    public GameObject NM;



    void Update()
    {
        cashValue = PlayerPrefs.GetFloat("cash", cashValue);
        if (cashValue >= 1000)
        {
            rp.GetComponent<Button>().interactable = true;
        }

        if (cashValue >= 1000)
        {
            wp.GetComponent<Button>().interactable = true;
        }

        if (cashValue >= 1000)
        {
            bp.GetComponent<Button>().interactable = true;
        }

        if (cashValue >= 10000)
        {
            NM.GetComponent<Button>().interactable = true;
        }
    }

    public void rpUnlock()
    {
        rp.SetActive(false);
        cashValue -= 1000;
        PlayerPrefs.SetFloat("cash", cashValue);
        PlayerPrefs.SetInt("rp", 100);
    }

    public void wpUnlock()
    {
        wp.SetActive(false);
        cashValue -= 1000;
        PlayerPrefs.SetFloat("cash", cashValue);
        PlayerPrefs.SetInt("wp", 100);
    }

    public void bpUnlock()
    {
        bp.SetActive(false);
        cashValue -= 1000;
        PlayerPrefs.SetFloat("cash", cashValue);
        PlayerPrefs.SetInt("bp", 100);
    }


    public void NMUnlock()
    {
        NM.SetActive(false);
        cashValue -= 10000;
        PlayerPrefs.SetFloat("cash", cashValue);
        PlayerPrefs.SetInt("nm", 100);
    }
}
