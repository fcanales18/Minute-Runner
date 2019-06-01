using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //This is a reference to the Rigidbody comoponent called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;  //Variable that determines the foward force
    public float sidewaysForce = 500f;  //Variable that determines the sideway force

    // Mark this as "Fixed"Update because we are using it to mess with physics.
	void FixedUpdate ()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  

        if ( Input.GetKey("d") )    // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))  // If the player is pressing the "a" key
        {
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        // Ends game when falls off ground
        if(rb.position.y < -10f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
 
}
