using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObj : MonoBehaviour
{
    private Transform player;
    private const float PLAYER_DISTANCE = 200f;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) > PLAYER_DISTANCE)
        {
            Destroy(gameObject);
        }
    }

    
}
