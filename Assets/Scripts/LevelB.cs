using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelB : MonoBehaviour
{
    public GameObject pr;
    public GameObject curr;
    public GameObject next;

    public void nextL()
    {
        curr.SetActive(false);
        next.SetActive(true);
    }
    public void prl()
    {
        curr.SetActive(false);
        pr.SetActive(true);
    }
}
