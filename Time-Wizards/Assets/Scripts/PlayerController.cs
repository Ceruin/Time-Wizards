using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController controller;

    [SerializeField] Transform groundCheck;
    [SerializeField] float groundDistance = 0.4f;
    [SerializeField] LayerMask groundMask;

    [SerializeField] float jumpHeight = 3f;
    [SerializeField] float moveSpeed = 12.0f;
    [SerializeField] float gravity = -9.81f;

    public float currentSpeed = 0;
    float acceleration = 0.05f;
    int maxSpeed = 10;
    float bHopTime = 400f;

    Vector3 velocity;
    bool isGrounded;

    Stopwatch timer = new Stopwatch();

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded)
        {
            timer.Start();
        } else
        {
            timer.Stop();
            timer.Reset();
        }


        if (isGrounded && velocity.y <= 0)
        {
            velocity.y = -2f;
        }

        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.right * xMovement + transform.forward * zMovement;

        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        if (!isGrounded)
        {
            velocity.x += moveDirection.x * acceleration; // velocity buildup on the horizontal axis
            velocity.z += moveDirection.z * acceleration; // velocity buildup on the vertical axis
        }
        else
        {
            if (timer.ElapsedMilliseconds > bHopTime)
            {
                velocity.x = 0;
                velocity.z = 0;
            }
        }

        velocity = Vector3.ClampMagnitude(velocity, maxSpeed); // clamp the speed so the character doesn't accelerate forever

        currentSpeed = velocity.x;
        controller.Move(velocity * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

    }
}
