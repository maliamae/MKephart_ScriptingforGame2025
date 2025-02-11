using UnityEngine;

public class RubeMarbleBehavior : MonoBehaviour
{
    public Material yellowMat;

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
            this.GetComponent<MeshRenderer>().material = yellowMat;
        }

        
        if(other.gameObject.tag == "LockedWall" && other.gameObject.GetComponent<MeshRenderer>().material == this.GetComponent<MeshRenderer>().material)
        {
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        
    }
}
