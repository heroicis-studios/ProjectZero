using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

    private void Start()
    {
        player.GetComponent<ForwardForever3D>().cam = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; 
    }
}
