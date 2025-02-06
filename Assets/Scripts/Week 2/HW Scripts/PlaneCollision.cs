using UnityEngine;

public class PlaneCollision : MonoBehaviour
{
    public SFXChanging audioController;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        audioController.PlayBoo();
    }
}
