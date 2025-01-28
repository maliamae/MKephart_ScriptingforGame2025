using UnityEngine;

public class FloatManipulation : MonoBehaviour
{
    public float varA;
    public float varB;
    public float varC;

    float total;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        total = (varA + varB + varC) / 3;
        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
