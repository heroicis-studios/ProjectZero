using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//making sure that there is a Rigidbody on this game object
[RequireComponent(typeof(Rigidbody))]
public class ForwardForever3D : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 1000000f;

    public bool canJump = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        //applying forward force every frame multiplied by time since last frame
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //if d or right arrow is pressed, apply a sideways force to the right
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);

        }

        //if a or left arrow is pressed, apply a sideways force to the left
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);

        }

        //if space, w or up arrow is pressed, call function jump
        if (Input.GetKey("w") || Input.GetKey("up") || Input.GetKey("space"))
        {
            Debug.Log("Input Triggered");
            Jump();
        }
    }

    public void Jump()
    {
        Debug.Log("Function Called: y =" + transform.position.y);
        //check to make sure that y = 1 and the player is allowed to jump
        if (transform.position.y == 1f)
        {
            Debug.Log("Passed Inspection");
            rb.AddForce(0, jumpForce, 0);
        }
    }
}
