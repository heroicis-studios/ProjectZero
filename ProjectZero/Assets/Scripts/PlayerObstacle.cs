using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObstacle : MonoBehaviour
{

    public PlayerDie die;
    private Transform player;

    //when an object collides with something, this is called
    private void OnCollisionEnter(Collision collision)
    {
        //checking the 'layer' that the object we collided with is on
        if (collision.collider.gameObject.layer == 9) {
            die.Die();
        }
    }
}
