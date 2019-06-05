using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//making sure that there is a Rigidbody on this game object
[RequireComponent(typeof(Rigidbody))]
public class ForwardForever3D : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public float forwardSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //checking to see if player has NOT got a value asigned yet
        if (player != null)
        {
            //setting it equal to the Transform on this game object
            player = GetComponent<Transform>();
        }
        //checking to see if rb has NOT got a value asigned yet
        if (rb != null)
        {
            //setting it equal to the Rigidbody on this game object
            rb = GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //called every physics update
    private void FixedUpdate()
    {
        Vector3 velocity = (forwardSpeed, 0f, 0f) * Time.deltaTime;

        rb.MovePosition(velocity);
    }
}
