using UnityEngine;

public class TimerCountingDown : MonoBehaviour
{
    public float timerCountingDown = 5f;
    public float timerMax = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timerCountingDown <= timerMax)
        {
            Debug.Log("END OF TIMER");
            timerCountingDown = 5f;
        } 
        else
        {
            timerCountingDown -= Time.deltaTime;
        }
    }
}
