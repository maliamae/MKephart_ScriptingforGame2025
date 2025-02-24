using UnityEngine;

public class CannonFire : MonoBehaviour
{
    public GameObject cannonballPrefab;
    public Transform cannonballSpawnPos;

    public float force = 500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }
        */
    }

    public void FireCannon()
    {
        GameObject go = Instantiate(cannonballPrefab, cannonballSpawnPos.position, cannonballSpawnPos.rotation);
        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * force);
    }
}
