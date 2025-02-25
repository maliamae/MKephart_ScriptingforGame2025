using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    //script spawns a random number of "Bobombs" and adds them to a public list

    public GameObject enemyPrefab; //prefab that will be instantiated
    public int enemiesMin = 20; //minimum number of Bobombs to spawn
    public int enemiesMax = 40; //maximum number of Bobombs to instantiate

    public List<EnemyOrbs> enemyList = new List<EnemyOrbs>(); //empty list the Bobombs will be added to

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnEnemies(); //spawns a random number of Bobombs once
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //the following function spawns a random number of Bobombs with a random position over a designated area
    public void spawnEnemies()
    {
        int randomSpawnNum = Random.Range(enemiesMin, enemiesMax+1); //random number to spawn is selected

        for (int count = 0; count < randomSpawnNum; count ++) //for loop spawns a new Bobomb until the nmber of Bobombs matches the random number selected to spawn above
        {
            Vector3 randomPosition = Vector3.zero;
            randomPosition.x = Random.Range(-8f,8.5f);
            randomPosition.y = Random.Range(1f, 1.5f);
            randomPosition.z = Random.Range(-6f, 6f);

            GameObject newEnemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            enemyList.Add(newEnemy.GetComponent<EnemyOrbs>()); //adds each new Bobomb to the list
        }
    }
}
