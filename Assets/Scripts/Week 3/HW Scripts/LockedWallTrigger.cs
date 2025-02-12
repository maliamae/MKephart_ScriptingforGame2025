using UnityEngine;

public class LockedWallTrigger : MonoBehaviour
{
    public GameObject wallCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider otherObject)
    {
        /*
        if(otherObject.gameObject.GetComponent<SphereCollider>().enabled == false)
        {
            otherObject.gameObject.GetComponent<SphereCollider>().enabled = true;
        }
        */
        Debug.Log("Exit");
        wallCollider.gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
