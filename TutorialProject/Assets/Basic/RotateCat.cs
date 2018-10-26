using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCat : MonoBehaviour {

    public float moveSpeed = 4f;
    public float trunSpeed = 6f;
    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * trunSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(-Vector3.up * trunSpeed * Time.deltaTime);

    }
}
