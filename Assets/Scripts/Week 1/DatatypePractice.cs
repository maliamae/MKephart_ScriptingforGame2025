using UnityEngine;

public class DatatypePractice : MonoBehaviour
{

    float santaClaus;

    float total;
    public float yoshi = 4.8f;
    public float mario;

    char bee = 'B';

    string intro = "Hello World";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        santaClaus = 56;
        santaClaus = (santaClaus + 5) * 2 / (3 - 7.5f);

        Debug.Log(yoshi);
         //Substracts 2 from the current value of yoshi
        yoshi -= 2;

        Debug.Log("Yoshi's value is: " + yoshi);

        Debug.Log(bee + intro);

        total = mario + yoshi;
        Debug.Log("M+Y" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
