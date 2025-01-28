using UnityEngine;

public class IntegerManipulation : MonoBehaviour
{
    int varA = 3;
    int varB = 12;
    int varC = 0;

    int total;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        total = ((varB / varA) * varC + varA) * varC;

        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
