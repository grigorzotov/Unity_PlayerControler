using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 300f;
    public float sidewaysForce = 100f;
	
	// Update is called once per frame
	void FixedUpdate () {
        //Move Foreward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Controlls
        if (Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("left")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManagerSrc>().GameOver();
        }
           
     }
	
}
