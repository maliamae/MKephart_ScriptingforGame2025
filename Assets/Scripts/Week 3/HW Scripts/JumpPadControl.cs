using UnityEngine;

public class JumpPadControl : MonoBehaviour
{
    public int jumpForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision otherObject)
    {
        otherObject.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
    }
   
}
