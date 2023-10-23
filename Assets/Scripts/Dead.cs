using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public bool isDead;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject player;
    private PlayerMovement script;
    Animator anim;

    void Start()
    {
        script = player.GetComponent<PlayerMovement>();
        anim = player.GetComponent<Animator>();
        panel.SetActive(false);
        anim.ResetTrigger("Box");
        anim.ResetTrigger("Rock");
        isDead = false;
    }

    public void boxDead()
    {
        panel.SetActive(true);
        script.enabled = false;
        anim.SetTrigger("Box");
        isDead = true;
    }

    public void rockDead()
    {
        panel.SetActive(true);
        script.enabled = false;
        anim.SetTrigger("Rock");
        isDead = true;
    }
}
