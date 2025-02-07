using UnityEngine;

public class TiltPlane : MonoBehaviour
{
    //script that controls the tilting of the box to the left or to the right based on player inputs
    public MarbleBehavior marbleController;

    public GameObject planeToTilt;
    public Vector3 rotationAmount;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //box starts with some rotation so that the first marble immediately has a direction to go in
    void Start()
    {
        planeToTilt.transform.Rotate(rotationAmount *2); 
    }

    // Update is called once per frame
    void Update()
    {
        //when the player presses 'A', the platform tilts to the left by the angle specified in the inspector
        if(Input.GetKeyDown(KeyCode.A))
        {
            planeToTilt.transform.Rotate(rotationAmount);
        }

        //when the player presses 'D', the platform tilts to the right by the angle specified in the inspector
        if (Input.GetKeyDown(KeyCode.D))
        {
            planeToTilt.transform.Rotate(rotationAmount * -1);
        }

        //when the player hits the spacebar, another marble spawns
        if(Input.GetKeyDown(KeyCode.Space))
        {
            marbleController.SpawnMarble(); //accesses the SpawnMarble() function from MarbleBehavior script to spawn a new marble each time the spacebar is hit
        }
    }

}
