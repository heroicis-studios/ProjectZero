using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeedUp : MonoBehaviour
{

    public float SpeedChange = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Player Protocol")
        {
            ForwardForever3D playerScript = collision.collider.gameObject.GetComponentInParent<ForwardForever3D>();
            playerScript.speedMultiplier = playerScript.speedMultiplier + SpeedChange;
        }
    }
}
