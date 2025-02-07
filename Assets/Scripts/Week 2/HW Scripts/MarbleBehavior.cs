using UnityEngine;

public class MarbleBehavior : MonoBehaviour
{
    //script controls the marble (ball) behavior
    public GameObject marbleOriginal;
    public Vector3 marbleStartPos;

    public CrowdMovement crowdController;

    GameObject newMarble;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spawns one instance of the marble at the start of the scene to avoid destroying the original sphere from which all the marbles are cloned
        SpawnMarble();
    }

    //function to spawn a marble upon pressing the spacebar or clicking the button on screen
    public void SpawnMarble()
    {
        //new marbles are instances of the original marble (ImmortalMarble) meaning they have all the same components as the original (Rigidbody, Audio Source, etc.)
        //this way the same "pop" sound plays each time a marble is spawned, and there can be as many marbles as the player wants
        newMarble = Instantiate(marbleOriginal, marbleStartPos, Quaternion.identity); //I don't completely understand quaternions yet but from what I learned off of unity documentation this spawns the new game objects with no rotation changes from the original
        newMarble.SetActive(true); //the original marble is inactive so it can never be destroyed, here I make the clones active so they are visible and fall

        crowdController.speed += 5; //accesses the speed variable from the CrowdMovement script so that each time a marble is spawned, the crowd gets slightly faster
    }
}
