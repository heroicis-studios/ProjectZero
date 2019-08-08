using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardForever3DProtocol : MonoBehaviour
{
    public Transform protocol;
    public float protocolYPos;
    public Vector2 ProtocolXandZ;

    private Transform player;

    private void Start()
    {
        player = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        float newXPos = protocol.position.x + ProtocolXandZ.x;
        float newZPos = protocol.position.z + ProtocolXandZ.y;
        Vector3 newProtocolPosition = new Vector3(newXPos, protocolYPos, newZPos);
        protocol.position = newProtocolPosition;
    }
}
