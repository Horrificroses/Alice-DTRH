using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene to load when interacting with the door
    public float interactionDistance = 2f; // Distance at which the player can interact with the door

    private bool isNearDoor;

    void Update()
    {
        if (isNearDoor && Input.GetKeyDown(KeyCode.Space))
        {
            LoadNewScene();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            isNearDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            isNearDoor = false;
        }
    }

    void LoadNewScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
