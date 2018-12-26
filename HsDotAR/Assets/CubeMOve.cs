using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMOve : MonoBehaviour {

    private float speed = 10f;
    Rigidbody rb;
    
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // transform.Translate(Vector3.forward * speed * Time.deltaTime);
            rb.AddForce(new Vector3(1, 2, 5) * Time.deltaTime * speed, ForceMode.Impulse);
            
            Destroy(this.gameObject, 5f);
        }       
    }
}
