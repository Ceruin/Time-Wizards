using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 6.0f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
      
    }

    void Update()
    {
        // move direction directly from axes
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= moveSpeed;
        transform.TransformDirection(moveDirection);

        // Move the controller
        transform.position += moveDirection * Time.deltaTime;
    }
}
