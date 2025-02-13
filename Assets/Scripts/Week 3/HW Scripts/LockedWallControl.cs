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

    private void OnCollisionStay(Collision otherObject)
    {
        Debug.Log("Enter");
        
        
        if (otherObject.gameObject.GetComponent<MeshRenderer>().material.color == this.GetComponent<MeshRenderer>().material.color)
        {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }

    }
    
}
