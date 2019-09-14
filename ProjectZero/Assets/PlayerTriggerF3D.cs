using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerF3D : MonoBehaviour
{
    private ForwardForever3D f3d;

    private void Start()
    {
        f3d = GetComponent<ForwardForever3D>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerSpeedUp>() != null)
        {
            PlayerSpeedUp SpeedUp = other.GetComponent<PlayerSpeedUp>();
            f3d.speedMultiplier += SpeedUp.playerSpeedChange;
        }
    }
}
