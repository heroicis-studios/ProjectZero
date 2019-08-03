using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardForever3DProtocol : MonoBehaviour
{
    public Transform protocol;
    public Vector3 offset;

    private Transform player;

    private void Start()
    {
        player = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        protocol.position = protocol.position + offset;
    }
}
