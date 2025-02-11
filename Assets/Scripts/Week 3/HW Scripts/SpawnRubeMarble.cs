using UnityEngine;

public class SpawnRubeMarble : MonoBehaviour
{
    public GameObject marblePrefab;
    public int startSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject playerMarble = Instantiate(marblePrefab, marblePrefab.transform.position, Quaternion.identity);
        playerMarble.GetComponent<Rigidbody>().AddForce(Vector3.right * startSpeed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            this.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
    }
}
