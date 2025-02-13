using UnityEngine;

public class SpawnRubeMarble : MonoBehaviour
{
    public GameObject marblePrefab;
    public int startSpeed;
    public Material blueMat;
    public Material pinkMat;
    int count = 0;

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

    public void SpawnMarble(Vector3 parentPosition)
    {
        Vector3 newPositionLeft = parentPosition + (Vector3.left * 2);
        Vector3 newPositionRight = parentPosition + (Vector3.right * 2);
        
        if (count == 0)
        {
            GameObject marbleInstance = Instantiate(marblePrefab, newPositionLeft, Quaternion.identity);
            marbleInstance.GetComponent<MeshRenderer>().material = blueMat;
        }
        else if (count == 1)
        {
            GameObject marbleInstance = Instantiate(marblePrefab, newPositionRight, Quaternion.identity);
            marbleInstance.GetComponent<MeshRenderer>().material = pinkMat;
        }

        count++;
    }
}
