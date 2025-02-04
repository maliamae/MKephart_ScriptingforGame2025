using UnityEngine;

public class CrowdMovement : MonoBehaviour
{
    public GameObject crowdImage;
    public Vector3 wiggleAmount;
    public int speed;

    bool atLimit = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
       
         if(crowdImage.transform.position.y < 300 && atLimit == false)
         {
             crowdImage.transform.position += wiggleAmount * speed * Time.deltaTime;

             if(crowdImage.transform.position.y >= 300)
             {
                 atLimit = true;
             }
         }

         if(crowdImage.transform.position.y > 200 && atLimit == true)
         {
             crowdImage.transform.position -= wiggleAmount * speed * Time.deltaTime;

             if(crowdImage.transform.position.y <= 200)
             {
                 atLimit = false;
             }
         }
         
    }
}
