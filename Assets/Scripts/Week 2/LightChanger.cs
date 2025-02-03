using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public Light lightToChange;
    public Vector3 lightMovDir;

    public bool isItOrIsntIt = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeLightColor(Color.blue);
        this.gameObject.SetActive(isItOrIsntIt);
        //lightToChange.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //AdjustLight();
        Debug.Log("Light object has been adjusted");
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(lightToChange.color == Color.blue)
            {
                ChangeLightColor(Color.green);
            }
            else
            {
                ChangeLightColor(Color.blue);
            }
            
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            lightToChange.gameObject.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            lightToChange.gameObject.SetActive(true);
        }

    }
    /*
    private void OnEnable()
    {
        //when this object is set active again, it will call the code from this function
    }

    private void OnDisable()
    {
        //when this object is set inactive, it will run this code before completely disabled
    }

    private void Awake()
    {
        //called before start 
    }
    */
    private void AdjustLight()
    {
        lightToChange.transform.position += lightMovDir * Time.deltaTime;
        lightToChange.intensity += 40f * Time.deltaTime;
        lightToChange.spotAngle += 10f * Time.deltaTime;
    }

    public void ChangeLightColor(Color lightColor)
    {
        lightToChange.color = lightColor;
    }
}
