using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public Transform cameraTransform;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the ball is grounded
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1f, groundLayer);

        // Debug raycast
        Debug.DrawRay(transform.position, Vector3.down * 1f, Color.red);

        // Move the ball based on camera direction
        Vector3 moveDirection = GetMoveDirection();
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, rb.velocity.y, moveDirection.z * moveSpeed);

        // Jump
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    Vector3 GetMoveDirection()
    {
        // Get input from WASD keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate move direction based on camera forward and right vectors
        Vector3 moveDirection = cameraTransform.forward * verticalInput + cameraTransform.right * horizontalInput;
        moveDirection.y = 0f; // Ensure the ball stays on the same plane (no flying)
        moveDirection.Normalize(); // Normalize to avoid faster movement diagonally

        return moveDirection;
    }
}
