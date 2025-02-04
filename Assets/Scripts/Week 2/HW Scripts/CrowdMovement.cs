using UnityEngine;

public class CrowdMovement : MonoBehaviour
{
    public GameObject crowdImage;
    public Vector3 wiggleAmount;
    public int speed;
    public float upperLimit;
    public float lowerLimit;

    bool atLimit = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         if(crowdImage.transform.position.y >= upperLimit)
        {
            atLimit = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
         if(crowdImage.transform.position.y < upperLimit && atLimit == false)
         {
             crowdImage.transform.position += wiggleAmount * speed * Time.deltaTime;

             if(crowdImage.transform.position.y >= upperLimit)
             {
                 atLimit = true;
             }
         }

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
