using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    Rigidbody2D rb;
    public float jumpForce;
    
   
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void Jump()
    {
        rb.AddForce(new Vector2(0, jumpForce));
    }

  
}
