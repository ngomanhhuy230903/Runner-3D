using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclesPrefab;
    private int spawnTime = 3;
    private int spawnCount = 3;
    private PlayerControllers playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllers>();
        InvokeRepeating("SpawnObstaclesPrefab", spawnTime, spawnCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstaclesPrefab()
    {
        int obstaclesIndex = Random.Range(0, obstaclesPrefab.Length);
        int randomPosition = Random.Range(27, 35);
        Vector3 spawnPos = new Vector3(randomPosition, 0, 0);
        Vector3 rotation = new Vector3(0, 0, 0);
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclesPrefab[obstaclesIndex], spawnPos, Quaternion.Euler(rotation));
        }        
    }
}
