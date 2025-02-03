using UnityEngine;

public class IKnowWhatYouAre : MonoBehaviour
{
    public GameObject dogPhobic;
    public GameObject deathScreen;
    public float scaleIncrease = .5f;
    public Vector3 rotationAmount;
    public Transform teleportTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dogPhobic.transform.localScale += (Vector3.one * scaleIncrease) * Time.deltaTime; // increases scale of selected image
        if(dogPhobic.transform.localScale.x > 30)
        {
            deathScreen.SetActive(true);
        }
    }

    public void ResetScale()
    {
        dogPhobic.transform.localScale = Vector3.one;
        scaleIncrease += .5f;
        dogPhobic.transform.position = new Vector3(450f, 253f, 0f);
    }

    public void RotateDog()
    {
        dogPhobic.transform.Rotate(rotationAmount);
    }

    public void TeleportDog()
    {
        dogPhobic.transform.position = teleportTransform.position;
    }
}
