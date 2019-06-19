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
    public float jumpForce = 100f;

    public bool canJump = true;
    public bool onGround;

    // Update is called once per frame
    void FixedUpdate()
    {
        //applying forward force every frame multiplied by time since last frame
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //if d or right arrow is pressed, apply a sideways force to the right
        if (Input.GetKeyDown("d") || Input.GetKeyDown("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);

        }

        //if a or left arrow is pressed, apply a sideways force to the left
        if (Input.GetKeyDown("a") || Input.GetKeyDown("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);

        }

        //if space, w or up arrow is pressed, call function jump
        if (Input.GetKeyDown("w") || Input.GetKeyDown("up") || Input.GetKeyDown("space"))
        {
            Debug.Log("Input Triggered");
            Jump();
        }
    }

    public void Jump()
    {
        Debug.Log(onGround);
        if (onGround)
        {
            Debug.Log("Passed Inspection");
            rb.AddForce(0, jumpForce, 0);
        }
    }

    void OnCollisionStay(Collision other)

    {
        if (other.gameObject.layer != 9)
        {
            onGround = false;
        }else if (other.gameObject.layer == 9)
        {
            onGround = true; //Add the jumping mechanic back in.
        }
    }
}
