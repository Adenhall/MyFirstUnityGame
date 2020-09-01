using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public Transform ground;
    public float speed = 2000f;
    public float backwardSpeed = 2000f;
    public float sidewaysSpeed = 2000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if (player.position.x >= ground.localScale.x/2-1)
        {
            player.position = new Vector3(ground.localScale.x/2-1, player.position.y, player.position.z);

        }

        if (player.position.x <= -ground.localScale.x / 2 + 1)
        {
            player.position = new Vector3(-ground.localScale.x / 2 + 1, player.position.y, player.position.z);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
