using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool hasKey = false;
    public bool hasRedKey = false;
    public bool hasBlueKey = false;
    public bool hasYellowKey = false;

    public GameObject playerCamera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            //are we looking at the door (Raycast)
            RaycastHit hitObject; //local Raycasr variable that contains the data of what will be hit by the raycast we are about to make

            if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hitObject, 10f))
            {
                if(hitObject.collider.gameObject.tag == "Door")
                {
                    Door targetDoor = hitObject.collider.gameObject.GetComponent<Door>();

                    if(hasKey == true)
                    {
                        //open door
                        if(hasRedKey == true && targetDoor.doorColor == KeyColor.Red)
                        {
                            targetDoor.OpenDoor();
                            Debug.Log("OPEN RED");
                        }
                        else if(hasBlueKey == true && targetDoor.doorColor == KeyColor.Blue)
                        {
                            targetDoor.OpenDoor();
                            Debug.Log("OPEN BLUE");
                        }
                        else if(hasYellowKey == true && targetDoor.doorColor == KeyColor.Yellow)
                        {
                            targetDoor.OpenDoor();
                            Debug.Log("OPEN YELLOW");
                        }
                        else
                        {
                            Debug.Log("nuh uh :)");
                        }
                    }
                    else
                    {
                        Debug.Log("nuh uh");
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Key")
        {
            KeyColor pickedUpKeyColor = other.gameObject.GetComponent<Key>().color;
            if(pickedUpKeyColor == KeyColor.Red)
            {
                hasRedKey = true;
                hasKey = true;
            }
            else if(pickedUpKeyColor == KeyColor.Blue)
            {
                hasBlueKey = true;
                hasKey = true;
            }
            else if (pickedUpKeyColor == KeyColor.Yellow)
            {
                hasYellowKey = true;
                hasKey = true;
            }
            Destroy(other.gameObject);
            //Debug.Log("KEY COLLECTED");
        }
    }
}
