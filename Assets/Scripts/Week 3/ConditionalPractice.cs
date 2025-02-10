using UnityEngine;

public class ConditionalPractice : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    public Color elseColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ColorGameObjectByName(go);
        //ColorGameObjectByName(go2);
        ColorGameObjectByTag(go);
        ColorGameObjectByTag(go2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ColorGameObjectByName(GameObject gogo)
    {
        Debug.Log("go is named: " + go.name);
        Debug.Log("go2 is named: " + go2.name);

        MeshRenderer goMeshRenderer = gogo.GetComponent<MeshRenderer>();

        if(gogo.name == "Cube")
        {
            goMeshRenderer.material.color = Color.magenta;
            //Change the color to magenta
        }
        else if(gogo.name == "Sphere")
        {
            goMeshRenderer.material.color = Color.cyan;
            //Change the color to cyan
        }
        else if(gogo.name == "Cylinder")
        {
            goMeshRenderer.material.color = Color.black;
            //Change the color to black
        }
        else
        {
            goMeshRenderer.material.color = elseColor;
            //change the color to orange
        }
    }

    void ColorGameObjectByTag(GameObject gogo)
    {
        MeshRenderer goMeshRenderer = gogo.GetComponent<MeshRenderer>();

        if (gogo.tag == "Cool")
        {
            goMeshRenderer.material.color = Color.magenta;
            //Change the color to magenta
        }
        else if (gogo.tag == "NotCool")
        {
            goMeshRenderer.material.color = Color.cyan;
            //Change the color to cyan
        }
        else if (gogo.tag == "Mid")
        {
            goMeshRenderer.material.color = Color.black;
            //Change the color to black
        }
        else
        {
            goMeshRenderer.material.color = elseColor;
            //change the color to orange
        }
    }
}
