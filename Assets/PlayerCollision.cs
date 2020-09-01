using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    // Update is called once per frame
    void OnCollisionEnter(Collision info)
    {
        if (info.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
