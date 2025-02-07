using UnityEngine;

public class SFXChanging : MonoBehaviour
{
    //script controls the sound effects of the crowd
    public GameObject audioController;

    //ive added both clips intending to pause the cheering each time the booing plays but I couldn't figure it out
    public AudioClip crowdCheering;
    public AudioClip crowdBooing;

    AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*
    void Start()
    {
        audioSource = audioController.GetComponent<AudioSource>();
    }
    */

    //plays the "booing" audio clip once each time the function is called
    public void PlayBoo()
    {
        //audioSource.PlayOneShot(crowdBooing);
        audioController.GetComponent<AudioSource>().PlayOneShot(crowdBooing);
    }
}
