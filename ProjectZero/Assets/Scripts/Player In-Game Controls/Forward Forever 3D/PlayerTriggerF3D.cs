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
        if(other.GetComponent<PlayerSpeedUpF3D>() != null)
        {
            PlayerSpeedUpF3D SpeedUp = other.GetComponent<PlayerSpeedUpF3D>();
            f3d.speedMultiplier += SpeedUp.playerSpeedChange;
        }else if(other.GetComponent<CampaignLevelCompleteF3D>() != null)
        {
            CampaignLevelCompleteF3D clc = other.GetComponent<CampaignLevelCompleteF3D>();
            f3d.isSpeedStatic = true;
        }
    }
}