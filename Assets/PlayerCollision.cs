using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Obstacle")
        {
            Debug.Log("Hit the Obstacle");
        }
    }
}
