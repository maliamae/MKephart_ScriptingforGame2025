using UnityEngine;

public class MarbleBehavior : MonoBehaviour
{
    public GameObject marbleOriginal;
    public Vector3 marbleStartPos;

    //public TiltPlane planeController;
    public CrowdMovement crowdController;

    GameObject newMarble;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnMarble();
    }

    public void SpawnMarble()
    {
        newMarble = Instantiate(marbleOriginal, marbleStartPos, Quaternion.identity);
        newMarble.SetActive(true);

        crowdController.speed += 5;
        //planeController.rotationAmount += new Vector3(0,0,2);
    }
}
