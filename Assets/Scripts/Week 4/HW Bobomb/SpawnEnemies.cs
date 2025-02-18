using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemiesMin = 20;
    public int enemiesMax = 40;

    public List<EnemyOrbs> enemyList = new List<EnemyOrbs>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnEnemies()
    {
        int randomSpawnNum = Random.Range(enemiesMin, enemiesMax+1);
        for (int count = 0; count < randomSpawnNum; count ++)
        {
            Vector3 randomPosition = Vector3.zero;
            randomPosition.x = Random.Range(-8f,8.5f);
            randomPosition.y = Random.Range(1f, 1.5f);
            randomPosition.z = Random.Range(-6f, 6f);

            GameObject newEnemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            enemyList.Add(newEnemy.GetComponent<EnemyOrbs>());
        }
    }
}
