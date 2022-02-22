using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
private Rigidbody rb;
    [SerializeField] private float verticalThrust;
    [SerializeField] private float horizontalThrust;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0) {
            rb.AddForce(0, verticalThrust * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (Input.GetAxis("Horizontal") != 0) {
            rb.AddForce(horizontalThrust * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetAxis("Vertical") != 0) {
            rb.AddForce(0, 0, horizontalThrust * Input.GetAxis("Vertical") * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
