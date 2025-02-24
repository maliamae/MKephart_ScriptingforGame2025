using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    public TextMeshProUGUI counterDisplay;
    public TextMeshProUGUI checkCounter;
    public TextMeshProUGUI timerDisplay;

    int playerCount = 0;
    float checkCount = 0;

    public float gameTime = 30f;
    public float currentTime = 0f;
    public float countDownTimer = 0f;

    public SpawnEnemies enemiesController;
    int totalCount;

    bool gameFinish = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        countDownTimer = gameTime;
        gameFinish = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (gameFinish == false)
        {
            currentTime += Time.deltaTime;
            countDownTimer -= Time.deltaTime;

            timerDisplay.text = countDownTimer.ToString("#.00");

            if (Input.GetKeyDown(KeyCode.A))
            {
                playerCount++;
                counterDisplay.text = playerCount.ToString();
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                playerCount--;
                counterDisplay.text = playerCount.ToString();
            }

            if (countDownTimer <= 0)
            {
                gameFinish = true;
            }
        }

        if (gameFinish == true)
        {
            Debug.Log("FINSIH");
            timerDisplay.text = "00.00";

            totalCount = enemiesController.enemyList.Count;

            if (checkCount <= totalCount)
            {
                Debug.Log("check: " + checkCount + " total: " + totalCount);
                checkCount += Time.deltaTime * 10;
                checkCounter.text = checkCount.ToString("F0");

                checkCounter.fontSize += 0.2f;
            }
        }
        
    }

    
    IEnumerator AddCheckCounter()
    {
        yield return new WaitForSeconds(0.5f);

        checkCount++;
        checkCounter.text = checkCount.ToString();
    }
    
}
