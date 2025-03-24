using UnityEngine;

public class WhileLoopTest : MonoBehaviour
{
    public float speed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while(this.transform.position.x < 7f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        while(this.transform.position.y < 10f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
