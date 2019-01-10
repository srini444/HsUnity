using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSwipe : MonoBehaviour {
    
    Rigidbody rb;

    [SerializeField]
    public float jumpForce;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	
	void Update ()
    {
		
	}
    public void upSwipe()
    {
        rb.AddForce(new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(4f, 8f), 15f) * jumpForce * Time.deltaTime, ForceMode.Impulse);
    }
    public void leftSwipe()
    {        
        rb.AddForce(new Vector3(Random.Range(-3f, 0f), 5f, 15f) * jumpForce * Time.deltaTime, ForceMode.Impulse);
    }
    public void rightSwipe()
    {
        rb.AddForce(new Vector3(Random.Range(0f, 3f), 5f, 15f) * jumpForce * Time.deltaTime, ForceMode.Impulse);
    }
}
