using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Rigidbody rb;
    public PlayerMovement movement; //A reference to our PlayerMovement script
    public SphereFall sf; //A reference to our SphereFall script
    public float upwardForce = 2000f;
    public float fowardForce = 2000f;
    public float slowedForce = -1000f;
    public float upwardLittleForce = 500f;

    //This function runs when we hit another object.
    //We get information about the collision and call it "collissionInfo".
	void OnCollisionEnter (Collision collisionInfo)
    {
        //We check if the object we collided with has a tag called "Obstacle"
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;   //Disable the players movement.
            FindObjectOfType<GameManager>().EndGame();
            
        }
        if (collisionInfo.collider.tag == "DragUp")
        {
            rb.AddForce(0, upwardForce, 0, ForceMode.Impulse);
        }
        if (collisionInfo.collider.tag == "SpeedUp")
        {
            rb.AddForce(0, 0, fowardForce, ForceMode.Impulse);
        }
        if (collisionInfo.collider.tag == "SlowDown")
        {
            rb.AddForce(0, 0, slowedForce, ForceMode.Impulse);
        }
        if (collisionInfo.collider.tag == "DragUpLittle")
        {
            rb.AddForce(0, upwardLittleForce, 0, ForceMode.Impulse);
        }
    }


	
}
