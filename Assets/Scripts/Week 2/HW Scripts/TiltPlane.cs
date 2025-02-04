using UnityEngine;

public class TiltPlane : MonoBehaviour
{
    public MarbleBehavior marbleController;

    public GameObject planeToTilt;
    public Vector3 rotationAmount;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        planeToTilt.transform.Rotate(rotationAmount *2); //test rotation is working
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            planeToTilt.transform.Rotate(rotationAmount);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            planeToTilt.transform.Rotate(rotationAmount * -1);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            marbleController.SpawnMarble();
        }
    }

}
