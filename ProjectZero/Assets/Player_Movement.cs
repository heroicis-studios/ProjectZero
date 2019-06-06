using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f; 
    // I used time dot deltatime because it keeps the frames steady.
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey ("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0); 

        }
    }
}
