using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDead : MonoBehaviour
{ 

    Dead DeadS;

    private void Start()
    {
        DeadS = GameObject.FindWithTag("GameManager").GetComponent<Dead>();
    }

    private void OnTriggerEnter(Collider other)
    {
        DeadS.boxDead();
    }
}
