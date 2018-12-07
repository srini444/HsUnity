using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    Rigidbody rb;
    public float jumpForce;


    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
		
	}
    public void Jump()
    {
        rb.AddForce(0f, jumpForce, jumpForce);
    }

 /*   public void JumpX()
    {
        rb.AddForce(0f, jumpForce, jumpForce);

    }
    */
}
