using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public Transform[] spawnPoints;

    public float spawnTime = 2f;
    private float spawnCounter;

    void Start()
    {
        spawnCounter = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        spawnCounter-= Time.deltaTime;
        if (spawnCounter < 0)
        {
            
            GameObject enemyInst = Instantiate(enemy, spawnPoints[0].position, Quaternion.identity) as GameObject;
            enemyInst.GetComponent<EnemyController>().walkRight = true;
            spawnCounter = spawnTime;
        }

    }
}
