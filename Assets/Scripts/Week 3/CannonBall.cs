using UnityEngine;

public class CannonBall : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddRandomForce()
    {
        Vector3 randomDir = Vector3.zero;
        randomDir.x = Random.Range(-1f, 1f);
        randomDir.y = Random.Range(0f, 1f);
        randomDir.z = Random.Range(-1f, 1f);

        float forceMult = Random.Range(1000, 5000);

        this.gameObject.GetComponent<Rigidbody>().AddForce(randomDir * forceMult);
    }

    /*
    private void OnCollisionEnter(Collision otherObject)
    {
        MeshRenderer cannonBallMeshRenderer = this.GetComponent<MeshRenderer>();
        MeshRenderer otherObjectMeshRenderer = otherObject.gameObject.GetComponent<MeshRenderer>();

        if (otherObject.gameObject.tag == "Floor")
        {
            cannonBallMeshRenderer.material.color = Color.blue;
            otherObjectMeshRenderer.material.color = Color.magenta;
            otherObject.gameObject.GetComponent<FloorScript>().SayHello();
        }
        else if (otherObject.gameObject.tag == "Floor2")
        {
            cannonBallMeshRenderer.material.color = Color.magenta;
            otherObjectMeshRenderer.material.color = Color.blue;
            otherObject.gameObject.GetComponent<FloorScript>().SayHello();
        }
        else if (otherObject.gameObject.tag == "CannonBall")
        {
            //No changes
        }
        else
        {
            cannonBallMeshRenderer.material.color = Color.white;
            otherObjectMeshRenderer.material.color = Color.black;
        }

    }

    private void OnTriggerEnter(Collider otherObject)
    {
        MeshRenderer cannonBallMeshRenderer = this.GetComponent<MeshRenderer>();
        MeshRenderer otherObjectMeshRenderer = otherObject.gameObject.GetComponent<MeshRenderer>();

        cannonBallMeshRenderer.material.color = Color.green;
        otherObjectMeshRenderer.material.color = Color.cyan;

        if (otherObject.gameObject.tag == "UpForce")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1500);
        }
        else if (otherObject.gameObject.tag == "DownForce")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 1500);
        }
    }
    */
}
