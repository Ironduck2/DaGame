using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private Vector2 moveSpeed;
    

    private void Update()
    {
        rb.velocity = moveSpeed * speed;

        if (Input.GetKey("w"))
        {
            moveSpeed = Vector3.up;
        }

        else if (Input.GetKey("s"))
        {
            moveSpeed = Vector3.down;
        }

        else if (Input.GetKey("d"))
        {
            moveSpeed = Vector3.right;
        }

        else if (Input.GetKey("a"))
        {
            moveSpeed = Vector3.left;
        }

        else
        {
            moveSpeed = Vector3.zero;
        }

        //-------------------------------------------------------

        if (Input.GetKey("w") && Input.GetKey("d"))
        {
            moveSpeed = new Vector3(1, 1, 0);
        }

        else if (Input.GetKey("d") && Input.GetKey("s"))
        {
            moveSpeed = new Vector3(1, -1, 0);
        }

        else if (Input.GetKey("s") && Input.GetKey("a"))
        {
            moveSpeed = new Vector3(-1, -1, 0);
        }

        else if (Input.GetKey("a") && Input.GetKey("w"))
        {
            moveSpeed = new Vector3(-1, 1, 0);
        }
    }
}
