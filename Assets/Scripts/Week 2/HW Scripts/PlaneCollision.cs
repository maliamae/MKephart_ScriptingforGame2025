using UnityEngine;

public class PlaneCollision : MonoBehaviour
{
    //script that destroys the marbles if they go past a certain point
    public SFXChanging audioController;

    //when other game objects collide with the one that contains this script, they are destroyed
    //i wanted to be able to spam the spawn marble function without worrying about performance
    private void OnTriggerEnter(Collider other) //accessing the collider components of the plane and the marbles
    {
        Destroy(other.gameObject); //destroys any object that collides with this one
        audioController.PlayBoo(); //accesses the PlayBoo() method from SFXChanging Script to play a "booing" sound from the crowd everytime a marble collides with it
    }
}
