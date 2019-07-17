﻿using System.Collections;
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

    // Update is called once per frame
    void FixedUpdate()
    {
        float VelocityX = 0f;
        VelocityX = 0f;

        //applying forward force every frame multiplied by time since last frame
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //if d or right arrow is pressed, apply a sideways force to the right
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            VelocityX = sidewaysForce * Time.deltaTime;
        }

        //if a or left arrow is pressed, apply a sideways force to the left
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            VelocityX = -sidewaysForce * Time.deltaTime;

        }

        //if space, w or up arrow is pressed, call function jump
        if (Input.GetKey("w") || Input.GetKey("up") || Input.GetKey("space"))
        {
            Jump();
        }

        float VelocityY = rb.velocity.y;
        Vector3 Velocity = new Vector3(VelocityX, VelocityY, forwardForce * Time.deltaTime);
        rb.velocity = Velocity;
    }

    public void Jump()
    {
        //check to see if the players velocity on the y-axis is 0
        if (rb.velocity.y == 0f)
        {
            //apply the jump force
            rb.AddForce(0, jumpForce, 0);
        }
    }
}
