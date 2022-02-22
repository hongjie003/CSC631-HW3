using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Camera camera1;
    [SerializeField] private Camera camera2;

    private void Awake() {
        camera1.enabled = true;
        camera2.enabled = false;
    }

    private void Update() {
        // Set position to player
        transform.position = player.position;

        // Check for camera switch
        if (Input.GetKeyDown(KeyCode.Q)) {
            if (camera1.enabled) { // Turn on camera 2
                camera2.enabled = true;
                camera1.enabled = false;
            }
            else if (!camera1.enabled) { // Turn on camera 1
                camera1.enabled = true;
                camera2.enabled = false;
            }
        }        
    }
}
