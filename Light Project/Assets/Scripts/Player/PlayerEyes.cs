using UnityEngine;

public class PlayerEyes : MonoBehaviour
{
    // Variables
    public Transform playerBody;
    public float mouseSensitivity;

    float xRotation = 0f;

    void Start()
    {
        // Locks Cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Gets Rotation * sensitivity
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Sets Clamp
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Rotates all to X
        playerBody.Rotate(Vector3.up * mouseX);
        // Rotates only camera to Y
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}