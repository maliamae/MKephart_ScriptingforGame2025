using UnityEngine;

public class SplitMarble : MonoBehaviour
{
    public SpawnRubeMarble marbleSpawner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("SPLIT DAMMIT");
        if (other.gameObject.tag == "Marble")
        {
            marbleSpawner.SpawnMarble(other.transform.position);
            marbleSpawner.SpawnMarble(other.transform.position);
            Destroy(other.gameObject);
        }
    }
}
