using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationTouch : MonoBehaviour {

    float rotSpeed = 10.0f;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnMouseDrag()
    {
        float x = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        transform.RotateAround(Vector3.down, x);
    }
}
