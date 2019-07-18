using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

//If a Transform is not present on the object, create one
[RequireComponent(typeof(Transform))]
public class PlayerDie : MonoBehaviour
{
    public float deathHeight = -10f;

    Transform trans;

    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
    }


    //called after the Update function
    private void LateUpdate()
    {
        //If the transform's y position is less than or equal to the deathHeight, 'Die'
        if (trans.position.y <= deathHeight)
        {
            Die();
        }
    }

    //placed into function as called from multiple places
    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //when an object collides with something, this is called
    private void OnCollisionEnter(Collision collision)
    {
        //checking the 'layer' that the object we collided with is on
        if (collision.collider.gameObject.layer == 9)
        {
            Die();
        }
    }

}
