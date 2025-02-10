using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    public GameObject cannonBallSpawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject go = Instantiate(cannonBallPrefab, cannonBallSpawnPosition.transform.position , cannonBallPrefab.transform.rotation);

        go.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(cannonBallPrefab, cannonBallSpawnPosition.transform.position, cannonBallPrefab.transform.rotation);
        }
    }
}
