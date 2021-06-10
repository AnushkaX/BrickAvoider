using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement playerMovement;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
        }
    }
}
