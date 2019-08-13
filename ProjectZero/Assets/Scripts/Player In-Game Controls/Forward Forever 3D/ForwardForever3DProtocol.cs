using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardForever3DProtocol : MonoBehaviour
{
    public Transform player;
    public float protocolYPos;

    private Transform protocol;
    
    private float avoidMin;
    private float avoidMax;

    private void Start()
    {
        protocol = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        float playerX = player.position.x;
        float playerZ = player.position.z;
        Vector3 newProtocolPosition = new Vector3(playerX, protocolYPos, playerZ);
        protocol.position = newProtocolPosition;
    }

    private void Update()
    {
        if (avoidMin << protocol.position.z && protocol.position.z << avoidMax)
        {
            protocol.gameObject.SetActive(false);
        }else
        {
            protocol.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        float maxplus = 2.001f;
        avoidMin = protocol.position.z;
        avoidMax = protocol.position.z + maxplus;
    }
}
