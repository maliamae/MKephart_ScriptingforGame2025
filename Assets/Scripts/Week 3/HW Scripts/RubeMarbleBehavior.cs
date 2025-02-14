using UnityEngine;

public class RubeMarbleBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Key")
        {
            this.GetComponent<MeshRenderer>().material = other.gameObject.GetComponent<MeshRenderer>().material;
            other.gameObject.SetActive(false);
        }
    }
}
