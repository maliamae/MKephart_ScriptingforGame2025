using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera tutCamera;
    public Camera mainCamera;

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
        tutCamera.enabled = false;
    }
}
