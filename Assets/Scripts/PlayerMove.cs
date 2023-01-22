using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public VariableJoystick joystick;
    public Animator animator;

    public float speed = 5f;
    public float speedRotation = 10f;

    void Update()
    {
        Vector2 mydirection = joystick.Direction;
        Vector3 movementVector = new Vector3(mydirection.x, 0, mydirection.y);

        movementVector = movementVector * Time.deltaTime * speed;
        transform.position += movementVector;

        if (movementVector.magnitude != 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(movementVector, Vector3.up), Time.deltaTime * speedRotation);
        }

        bool isWalking = mydirection.magnitude > 0;
        animator.SetBool("isWalking", isWalking);
        animator.SetFloat("Speed", mydirection.magnitude);

    }
}
