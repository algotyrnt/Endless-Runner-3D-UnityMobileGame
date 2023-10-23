using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    private const float PLAYER_DISTANCE = 100f;

    [SerializeField] private Transform start;
    [SerializeField] private List<Transform> LevelPartList;
    private Transform player;

    private Vector3 lastEndPosition;


    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;

        lastEndPosition = start.Find("End").position;

        int startingSpawnLevels = 5;
        for (int i = 0; i < startingSpawnLevels; i++)
        {
            SpawnLevelPart();
        }
    }

    private void Update()
    {
        if (Vector3.Distance(player.position, lastEndPosition) < PLAYER_DISTANCE)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = LevelPartList[Random.Range(0, LevelPartList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("End").position;
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
