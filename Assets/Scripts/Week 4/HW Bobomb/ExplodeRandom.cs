using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ExplodeRandom : MonoBehaviour
{
    public SpawnEnemies enemyController;
    public CounterManager timeManager;

    public float explosionTimeLimit = 25f;
    public float explosionTimeGapMin = 5f;
    public float explosionTimeGapMax = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("ExplodeRandomEnemy", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExplodeRandomEnemy()
    {
        if (timeManager.currentTime < timeManager.gameTime)
        {
            int totalEnemies = enemyController.enemyList.Count;
            int randomEnemyIndex = Random.Range(0, totalEnemies);
            float randomTimeGap = Random.Range(explosionTimeGapMin, explosionTimeGapMax);

            GameObject randomEnemy = enemyController.enemyList[randomEnemyIndex].gameObject;
            randomEnemy.GetComponent<MeshRenderer>().material.color = Color.red;

            StartCoroutine(ExplodeCoroutine(randomEnemy));

            Debug.Log("BOOM");
            Invoke("ExplodeRandomEnemy", randomTimeGap);
          
        }

    }

    IEnumerator ExplodeCoroutine(GameObject enemyOrb)
    {
        
        if (timeManager.currentTime < timeManager.gameTime)
        {
            yield return new WaitForSeconds(1);
            Debug.Log("FREEZE BOOM");
            enemyController.enemyList.Remove(enemyOrb.GetComponent<EnemyOrbs>());
            Destroy(enemyOrb);
        }

        //enemyOrb.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }

}
