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
        int totalEnemies = enemyController.enemyList.Count;
        int randomEnemy = Random.Range(0, totalEnemies);
        float randomTimeGap = Random.Range(explosionTimeGapMin, explosionTimeGapMax);

        enemyController.enemyList[randomEnemy].gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        enemyController.enemyList[randomEnemy].gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        if(timeManager.currentTime <= timeManager.gameTime)
        {
            Invoke("ExplodeRandomEnemt", randomTimeGap);
        }

    }
}
