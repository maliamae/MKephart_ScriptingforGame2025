using UnityEngine;

public class MoveObjectsWithDirection : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public float speed;

    public bool atDestination = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //gets direction every frame, moves point one in a curve
        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;
        Debug.Log(direction);
        point1.transform.position += direction * Time.deltaTime;
        */

        /*
        //normalizes direction and steadily moves object multiplied by speed variable
        //jitters (moves past exact location)
        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;
        direction = direction.normalized;

        Debug.Log(direction);
        point1.transform.position += (direction * speed) * Time.deltaTime;
        */

        /*
        //bounding the movement of point one if it is close enough to point 2
        //teleporting every single frame
        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;
        direction = direction.normalized;

        Debug.Log(direction);

        Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));

        if(Vector3.Distance(point1.transform.position, point2.transform.position) <= 0.1)
        {
            point1.transform.position = point2.transform.position;
        }
        else
        {
            point1.transform.position += (direction * speed) * Time.deltaTime;
        }
        */
        
        //runs only if point1 hasn't reached its destination
        if(atDestination == false)
        {
            Vector3 direction;

            direction = point2.transform.position - point1.transform.position;
            direction = direction.normalized;

            Debug.Log(direction);

            Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));

            if (Vector3.Distance(point1.transform.position, point2.transform.position) <= 0.1f)
            {
                point1.transform.position = point2.transform.position;
                atDestination = true;
            }
            else
            {
                point1.transform.position += (direction * speed) * Time.deltaTime;
            }
        }
        else
        {
            Debug.Log("Complete");
        }
    }

}
