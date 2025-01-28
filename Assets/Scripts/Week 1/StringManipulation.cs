using UnityEngine;

public class StringManipulation : MonoBehaviour
{
    public string beginning;
    public string middle;
    public string end;

    string total;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        total = beginning + " " + middle + " " + end + " but hold the " + end;
        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
