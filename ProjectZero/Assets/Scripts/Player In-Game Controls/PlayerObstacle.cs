using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObstacle : MonoBehaviour
{
    public float deathHeight = -10f;

    private Transform player;

    //called when scene initialized
    private void Start()
    {
        //if player variable has no value (null), then make it have the transform of this object
        if (player == null)
        {
            player = GetComponent<Transform>();
        }
    }
    
    //when an object collides with something, this is called
    private void OnCollisionEnter(Collision collision)
    {
        //checking the 'layer' that the object we collided with is on
        if (collision.collider.gameObject.layer == 9) {
            ResetPosition();
        }
    }

    //called after the Update function
    private void LateUpdate()
    {
        if(player.position.y <= deathHeight)
        {
            ResetPosition();
        }
    }

    //placed into function as called from multiple places
    public void ResetPosition()
    {
        //creating a vector3 of 0 2 0
        Vector3 newPos = new Vector3(0f, 2f, 0f);

        //set the player position to 0, 2, 0
        player.position = newPos;
    }

}
