using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public float timerCountingUp = 0f;
    public float timerMaxDuration = 3f;
    public bool hasFinishedTimer = false;

    public GameObject cube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerMaxDuration = Random.Range(1, 5);

        Invoke("MoveCubeRight", timerMaxDuration);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //ends the timer after it reaches a max number; prints once when it reaches max
        if(hasFinishedTimer == false)
        {
            if(timerCountingUp >= timerMaxDuration)
            {
                Debug.Log("END OF TIMER");
                hasFinishedTimer = true;
            }
            else
            {
                timerCountingUp += Time.deltaTime;
                Debug.Log(timerCountingUp);
            }
        }
        */
        
        /*
        //timer resets after counting up to the max and moves cube to the right by one unit
        if (timerCountingUp >= timerMaxDuration)
        {
            Debug.Log("END OF TIMER");
            timerCountingUp = 0f;

            MoveCubeRight();
        }
        else
        {
            timerCountingUp += Time.deltaTime;
        }
        */
        
    }

    public void MoveCubeRight()
    {
        cube.transform.position += Vector3.right;
        Debug.Log(timerMaxDuration);

        if(cube.transform.position.x <= 10)
        {
            Invoke("MoveCubeRight", timerMaxDuration);
        }
        
    }
}
