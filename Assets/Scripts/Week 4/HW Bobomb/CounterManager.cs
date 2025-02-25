using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    //script manages all of the UI and win/lose state

    public TextMeshProUGUI counterDisplay; //displays player counter
    public TextMeshProUGUI checkCounter; //displays actual total at end
    public TextMeshProUGUI timerDisplay; //displays the timer

    int playerCount = 0; //variable player manipulates up or down
    float checkCount = 0; //variable used to count up to the total number at the end

    public float gameTime = 30f; //total game time
    public float currentTime = 0f; //current time
    public float countDownTimer = 0f; //variable displayed as timer

    public SpawnEnemies enemiesController; //brought in to access list of Bobombs at the end to determine win/lose state
    int totalCount; //total number of Bobombs at the end 

    bool gameFinish = false; //used to limit actions to during game time and after game time

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        countDownTimer = gameTime; //timer begins at total game time
    }

    // Update is called once per frame
    void Update()
    {
        if (gameFinish == false)
        {
            currentTime += Time.deltaTime; //current time begins counting up from 0
            countDownTimer -= Time.deltaTime; //timer counts down from game time

            timerDisplay.text = "00:" + countDownTimer.ToString("F0"); //displays timer

            if (Input.GetKeyDown(KeyCode.A)) //player count goes up by one if A is pressed
            {
                playerCount++;
                counterDisplay.text = playerCount.ToString();
            }
            else if (Input.GetKeyDown(KeyCode.B) && playerCount > 0) //player count goes down if B is pressed (cannot go lower than 0)
            {
                playerCount--;
                counterDisplay.text = playerCount.ToString();
            }

            if (countDownTimer <= 0) //time runs out so the game is over
            {
                gameFinish = true;
            }
        }

        //once the game is over...
        if (gameFinish == true)
        {
            timerDisplay.text = "00:00"; //ensures the displayed time is always 00:00 when the game is over

            totalCount = enemiesController.enemyList.Count; //actual total number of Bobombs remaining

            if (checkCount <= totalCount) //gradually reveals true number of Bobombs to player and increases the font size of the display
            {
                //Debug.Log("check: " + checkCount + " total: " + totalCount);
                checkCount += Time.deltaTime * 10;
                checkCounter.text = checkCount.ToString("F0");

                checkCounter.fontSize += 0.15f;
            }
            else if (checkCount >= totalCount) //once the number is revealed to the player, win/lose condition is determined
            {
                if (playerCount == totalCount)
                {
                    Debug.Log("YOU WIN");
                }
                else if (playerCount != totalCount)
                {
                    Debug.Log("YOU LOSE");
                }
            }

            
        }
        
    }

    
}
