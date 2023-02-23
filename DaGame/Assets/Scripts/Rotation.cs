using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotation;
    Vector2 mousePos;

    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.right = Vector3.up;
        }

        if (Input.GetKey("down"))
        {
            transform.right = Vector3.down;
        }

        if (Input.GetKey("right"))
        {
            transform.right = Vector3.right;
        }

        if (Input.GetKey("left"))
        {
            transform.right = Vector3.left;
        }

        if (Input.GetKey("up") && Input.GetKey("right"))
        {
            transform.right = new Vector3(1,1,0);
        }

        if (Input.GetKey("right") && Input.GetKey("down"))
        {
            transform.right = new Vector3(1, -1, 0);
        }

        if (Input.GetKey("down") && Input.GetKey("left"))
        {
            transform.right = new Vector3(-1, -1, 0);
        }

        if (Input.GetKey("left") && Input.GetKey("up"))
        {
            transform.right = new Vector3(-1, 1, 0);
        }
    }
}
