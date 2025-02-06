using UnityEngine;

public class SFXChanging : MonoBehaviour
{
    public GameObject audioController;

    public AudioClip crowdCheering;
    public AudioClip crowdBooing;

    AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = audioController.GetComponent<AudioSource>();
    }

    public void PlayBoo()
    {
        audioSource.PlayOneShot(crowdBooing);
    }
}
