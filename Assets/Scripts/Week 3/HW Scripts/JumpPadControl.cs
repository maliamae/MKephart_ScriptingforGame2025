using UnityEngine;

public class JumpPadControl : MonoBehaviour
{
    public int jumpForce;
    public int rightForce;
    public int leftForce;

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
        otherObject.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * rightForce);
        otherObject.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * leftForce);
    }
   
}
