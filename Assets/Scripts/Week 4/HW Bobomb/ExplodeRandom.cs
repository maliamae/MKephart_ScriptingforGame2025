using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ExplodeRandom : MonoBehaviour
{
    //script controls the explosion of a random "Bobomb" 

    public SpawnEnemies enemyController; // to access list of total Bobombs
    public CounterManager timeManager; //to access current time

    public float explosionTimeLimit = 25f; //Bobombs can only explode within first 25 seconds of game
    public float explosionTimeGapMin = 5f; //minimum amount of time between explosions
    public float explosionTimeGapMax = 10f; //maximum amount of time between explosions

    public AudioClip explosionNoise;
    public AudioSource audioController;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("ExplodeRandomEnemy", 5f); //begins invoke loop of exploding Bobombs
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExplodeRandomEnemy() //selects a random Bobomb, gives it a red color, scales it up for one second, removes Bobomb from list, and destroys it
    {
        if (timeManager.currentTime < explosionTimeLimit)
        {
            int totalEnemies = enemyController.enemyList.Count; //gets current total of Bobombs in the list
            int randomEnemyIndex = Random.Range(0, totalEnemies); //selects a random index in list
            float randomTimeGap = Random.Range(explosionTimeGapMin, explosionTimeGapMax); //selects a random time before the next explosion
            
            GameObject randomEnemy = enemyController.enemyList[randomEnemyIndex].gameObject; //simplifies accessing the game object (Bobomb) that was randomly selected 

            SwapMesh(randomEnemy); //calls function to activate puffed up version of the model
            //randomEnemy.GetComponentInChildren<MeshRenderer>().material.color = Color.red; //change Bobomb color to red

            StartCoroutine(ExplodeCoroutine(randomEnemy)); //begins coroutine that actually destroys Bobomb

            Invoke("ExplodeRandomEnemy", randomTimeGap); //loops function
          
        }

    }

    //the following coroutine explodes the randomly selected Bobomb, scales it up for one second, then removes it from the list and destroys it
    IEnumerator ExplodeCoroutine(GameObject enemyOrb)
    {
        if (timeManager.currentTime < explosionTimeLimit)
        {
            float enemySize = 0; //used to limit while loop
            Vector3 scaleUpIncrement = Vector3.one * 0.065f; //step to scale up before being destroyed

            while (enemySize <= 0.5f) // repeats every 0.1 seconds until the size is 0.5
            {
                enemyOrb.GetComponent<Transform>().localScale += scaleUpIncrement; //scales selected Bobomb up
                enemySize += 0.05f; //ensures loop will end eventually

                yield return new WaitForSeconds(0.1f); //pauses coroutine for 0.1 seconds each loop
            }
            
            enemyController.enemyList.Remove(enemyOrb.GetComponent<EnemyOrbs>()); //removes selected Bobomb from list

            audioController.PlayOneShot(explosionNoise);

            Destroy(enemyOrb); //destroys selected Bobomb
        }

        //enemyOrb.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }

    //the following function swaps the active mesh of the parent object when called
    public void SwapMesh(GameObject parentObject)
    {
        GameObject fishFlat = parentObject.transform.GetChild(1).gameObject; //abstracts second child object of chosen gameobject
        GameObject fishPuff = parentObject.transform.GetChild(0).gameObject; //abstracts first child object of chosen gameobject

        fishFlat.SetActive(false); //current active mesh set to false
        fishPuff.SetActive(true); //puffed mesh set to active
    }

}
