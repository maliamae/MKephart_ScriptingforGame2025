using UnityEngine;

public class LockedWallControl : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherObject)
    {
        Debug.Log("Enter");
        float buffer = otherObject.transform.position.z - 1f;
        /*
        if (otherObject.gameObject.GetComponent<MeshRenderer>().material.color == this.GetComponent<MeshRenderer>().material.color)
        {
            otherObject.gameObject.GetComponent<SphereCollider>().enabled = false;
        }
        */
        if (otherObject.gameObject.GetComponent<MeshRenderer>().material.color == this.GetComponent<MeshRenderer>().material.color)
        {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }

    }

    private void OnCollisionExit()
    {
        Debug.Log("EXIT");
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
    }
    /*
    private void OnTriggerEnter(Collider otherObject)
    {
        
        if(otherObject.gameObject.GetComponent<SphereCollider>().enabled == false)
        {
            otherObject.gameObject.GetComponent<SphereCollider>().enabled = true;
        }
        
        Debug.Log("Exit");
        otherObject.gameObject.GetComponent<SphereCollider>().enabled = true;
    }
    */
}
