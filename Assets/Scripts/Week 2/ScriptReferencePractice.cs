using UnityEngine;

public class ScriptReferencePractice : MonoBehaviour
{
    public IKnowWhatYouAre dogController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dogController.scaleIncrease = 5f;
        dogController.RotateDog();
        dogController.TeleportDog();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
