using UnityEngine;

public class CrowdMovement : MonoBehaviour
{
    //script controls the up and down movements of the crowds (images)
    public GameObject crowdImage;
    public Vector3 wiggleAmount;
    public int speed;
    public float upperLimit;
    public float lowerLimit;

    bool atLimit = false; //used to keep the image within the bounds of the limits set in the inspector


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //atLimit is true if it exceeds or is equal to the upper limit set in the inspector
         if(crowdImage.transform.position.y >= upperLimit)
        {
            atLimit = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
       //image moves up if it is below the upper limit
       //once it reaches or exceeds that limit, atLimit is set to true so it can begin moving down
         if(crowdImage.transform.position.y < upperLimit && atLimit == false)
         {
             crowdImage.transform.position += wiggleAmount * speed * Time.deltaTime;

             if(crowdImage.transform.position.y >= upperLimit)
             {
                 atLimit = true;
             }
         }
        
         //image moves down if it is at the upper limit
         //once it reaches or exceeds the lower limit, atLimit is set to false so it can begin moving up again
         if(crowdImage.transform.position.y > lowerLimit && atLimit == true)
         {
             crowdImage.transform.position -= wiggleAmount * speed * Time.deltaTime;

             if(crowdImage.transform.position.y <= lowerLimit)
             {
                 atLimit = false;
             }
         }
         
    }
}
