using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AllListTest : MonoBehaviour
{
    public List<CannonBall> marbles = new List<CannonBall>();
    public GameObject cannonBallPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        marbles = FindObjectsByType<CannonBall>(FindObjectsSortMode.None).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //GameObject go = Instantiate(cannonBallPrefab);
            //marbles.Add(go.GetComponent<CannonBall>());
            foreach (CannonBall ball in marbles)
            {
                ball.AddRandomForce();
            }
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            int randomBall = Random.Range(0, marbles.Count);

            marbles[randomBall].gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
