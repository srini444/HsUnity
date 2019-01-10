using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSwipe : MonoBehaviour {

    Rigidbody rb;
    public float jumpForce;
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void jump()
    {
        rb.AddForce(new Vector3(0f, Random.Range(5f, 10f), Random.Range(5f,50f) * jumpForce), ForceMode.Impulse);
    }
}
