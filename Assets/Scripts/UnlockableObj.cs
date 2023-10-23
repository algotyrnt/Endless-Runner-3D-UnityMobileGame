using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockableObj : MonoBehaviour
{
    public int WP;
    public int RP;
    public int BP;

    public int NM;

    public GameObject fakeWP;
    public GameObject fakeRP;
    public GameObject fakeBP;

    public GameObject fakeNM;

    void Start()
    {
        WP = PlayerPrefs.GetInt("wp");
        if (WP == 100)
        {
            fakeWP.SetActive(false);
        }

        RP = PlayerPrefs.GetInt("rp");
        if (RP == 100)
        {
            fakeRP.SetActive(false);
        }

        BP = PlayerPrefs.GetInt("bp");
        if (BP == 100)
        {
            fakeBP.SetActive(false);
        }


        NM = PlayerPrefs.GetInt("nm");
        if (NM == 100)
        {
            fakeNM.SetActive(false);
        }

    }
}
