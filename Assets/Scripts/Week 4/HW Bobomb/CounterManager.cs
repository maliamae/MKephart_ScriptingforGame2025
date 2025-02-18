using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    public TextMeshProUGUI counterDisplay;
    int playerCount = 0;

    public float gameTime = 30f;
    public float currentTime = 0f;

    public SpawnEnemies enemiesController;
    int totalCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime <= gameTime)
        {
            if(Input.GetKeyDown(KeyCode.A))
            {
                playerCount +=1;
                counterDisplay.text = playerCount.ToString();
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                playerCount -= 1;
                counterDisplay.text = playerCount.ToString();
            }
        }
        else if(currentTime >= gameTime)
        {
            Debug.Log("FREEZE");
            totalCount = enemiesController.enemyList.Count;

            if (playerCount == totalCount)
            {
                Debug.Log("WIN");
            }
            else
            {
                Debug.Log("LOSE");
            }
        }
        
    }
}
