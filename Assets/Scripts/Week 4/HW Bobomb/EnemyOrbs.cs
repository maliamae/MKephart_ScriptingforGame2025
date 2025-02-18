using UnityEngine;

public class EnemyOrbs : MonoBehaviour
{
    public float forceTimeGapMax = 3f;
    public float forceTimeGapMin = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("AddRandomForce", forceTimeGapMin);
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

        float forceMult = Random.Range(75f,150f);

        float randomTimeGap = Random.Range(forceTimeGapMin, forceTimeGapMax);

        this.gameObject.GetComponent<Rigidbody>().AddForce(randomDir * forceMult);
        Invoke("AddRandomForce", randomTimeGap);
    }
}
