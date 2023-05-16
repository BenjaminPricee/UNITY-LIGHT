using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Variables
    private CharacterController playerController;
    public const float SPEED = 2.0f;

    private void Awake()
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get Input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * x) + (transform.forward * z);
        move.y = -0.5f;
        playerController.Move(move * SPEED * Time.deltaTime);
    }
}