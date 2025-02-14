using UnityEngine;
using UnityEngine.InputSystem;

public class LargeMarbleMaterialTracking : MonoBehaviour
{
    public GameObject yellowKey;
    public GameObject greenKey;
    public GameObject blueKey;
    public GameObject pinkKey;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KeyCollected(yellowKey);
        KeyCollected(greenKey);
        KeyCollected(blueKey);
        KeyCollected(pinkKey);
    }

    public void KeyCollected(GameObject key)
    {
        if(key.gameObject.activeSelf == false)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = key.GetComponent<MeshRenderer>().material.color;
        }
       
    }
}
