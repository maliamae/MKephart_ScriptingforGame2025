using UnityEngine;

public class EnemyOrbs : MonoBehaviour
{
    //script attached to each "Bobomb"
    //adds a randomized force to each Bobomb over the course of the game

    public float forceTimeGapMax = 3f; //maximum time between adding force
    public float forceTimeGapMin = 1f; //minimum time between adding force

    public float gameTime = 30f; //maximum game time
    float currentTime = 0f; //current time

    public AudioClip boingClip;
    public AudioSource audioController;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("AddRandomForce", forceTimeGapMin); //begins invoke loop of AddRandomForce
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime; //used to track if the allotted game time has passed

        if (currentTime >= gameTime) //freezes all Bobombs as soon as the game time is over
        {
            this.gameObject.GetComponentInChildren<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    //the following function adds a random force with a random delay at a random speed
    public void AddRandomForce()
    {
        Vector3 randomDir = Vector3.zero;
        randomDir.x = Random.Range(-1f, 1f);
        randomDir.y = Random.Range(0.5f, 2f);
        randomDir.z = Random.Range(-1f, 1f);

        float forceMult = Random.Range(75f,150f); //random speed

        float randomTimeGap = Random.Range(forceTimeGapMin, forceTimeGapMax); //random time delay

        this.gameObject.GetComponentInChildren<Rigidbody>().AddForce(randomDir * forceMult); 

        if(currentTime <= gameTime) //only continues to add force if the game time is not over
        {
            Invoke("AddRandomForce", randomTimeGap);
            
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(currentTime >= 0.1f)
        {
            //Debug.Log("collides");
            audioController.PlayOneShot(boingClip);
        }
       
    }
}
