using UnityEngine;

public class PositionManipulation : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 moveDir;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += moveDir * speed * Time.deltaTime;
    }
}
