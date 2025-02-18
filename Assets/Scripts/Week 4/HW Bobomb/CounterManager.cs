using UnityEngine;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    public GameObject counterDisplay;
    int count = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            count +=1;

            counterDisplay.GetComponent<TMPro.TextMeshPro>().text = "Kill Me";
        }
    }
}
