using UnityEngine;

public class TiltPlane : MonoBehaviour
{
    public GameObject planeToTilt;
    public Vector3 rotationAmount;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        planeToTilt.transform.Rotate(rotationAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
