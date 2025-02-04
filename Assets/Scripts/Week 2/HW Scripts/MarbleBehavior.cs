using UnityEngine;

public class MarbleBehavior : MonoBehaviour
{
    public GameObject marbleOriginal;
    public Vector3 marbleStartPos;
    public GameObject collisionPlane;

    GameObject newMarble;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnMarble();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnMarble()
    {
        newMarble = Instantiate(marbleOriginal, marbleStartPos, Quaternion.identity);
        newMarble.SetActive(true);
    }
}
