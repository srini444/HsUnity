using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClick : MonoBehaviour {

    Rigidbody rigidbody;
    // Use this for initialization
    void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
       // rigidbody.AddForce(transform.forward * 500f);
        rigidbody.AddForce(-Vector3.back * 500f);
        rigidbody.useGravity = true;
    }
}
