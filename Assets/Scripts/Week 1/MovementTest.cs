using UnityEngine;

public class MovementTest : MonoBehaviour
{

    public Vector3 startingPosition;
    public Vector3 moveDirection;
    public float speed = 1;

    // Start is called when this object first exists in the scene and the game is loaded
    void Start()
    {
        Debug.Log("Hello World");

        /*in reference to the object THIS script is on, gets reference to it's transform component 
         and get reference to the transform's position 
         and sets it to Vector3.zero which means (0,0,0).*/
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("stinky");

        this.transform.position += (moveDirection * speed) * Time.deltaTime;
    }
}
