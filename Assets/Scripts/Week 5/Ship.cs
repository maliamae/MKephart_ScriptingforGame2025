using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public List<CannonFire> cannons = new List<CannonFire>();
    int cannonIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannons = FindObjectsByType<CannonFire>(FindObjectsSortMode.InstanceID).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireAllCannons();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FireEvenCannons();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FireOddCannons();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            FireAllPowerfulCannons();
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            FireAllWeakCannons();
        }

    }

    void FireAllCannons()
    {
        foreach (CannonFire c in cannons)
        {
            c.FireCannon();
        }
    }

    void FireEvenCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            if (i % 2 == 0)
            {
                cannons[i].FireCannon();
            }

        }
    }

    void FireOddCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            if (i % 2 == 1)
            {
                cannons[i].FireCannon();
            }

        }
    }

    void FireCannonsInSequence()
    {
        if (cannonIndex < cannons.Count)
        {
            cannons[cannonIndex].FireCannon();
            cannonIndex++;
        }
        else if (cannonIndex >= cannons.Count)
        {
            cannonIndex = 0;
        }
    }

    void FireAllPowerfulCannons()
    {
        foreach (CannonFire c in cannons)
        {
            if (c.force >= 4500)
            {
                c.FireCannon();
            }
        }
    }

    void FireAllWeakCannons()
    {
        for(int i =0; i < cannons.Count; i++)
        {
            if (cannons[i].force < 4500)
            {
                cannons[i].FireCannon();
            }
        }
    }
}
