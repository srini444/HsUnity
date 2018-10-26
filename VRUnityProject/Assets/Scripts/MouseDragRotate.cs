using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragRotate : MonoBehaviour {

    public float rotateSpeed = 10f;

    void Start ()
    {
		
	}
		
	void Update ()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime);

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
     
}
