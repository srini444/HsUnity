using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrTouchRotation : MonoBehaviour {

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
        float rotx = Input.GetAxis("Mouse X") * Mathf.Deg2Rad;
        float roty = Input.GetAxis("Mouse Y") * Mathf.Deg2Rad;
        transform.RotateAround(Vector3.up, -rotx);
        transform.RotateAround(Vector3.right, roty);
        //transform.Rotate(0,5,0);
    }
}
