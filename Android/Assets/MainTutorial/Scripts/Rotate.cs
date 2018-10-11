using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float RotateSpeed = 5f;
    public float speed = 5f;
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        //Rotate X Direction
        //transform.Rotate(1 * RotateSpeed * Time.deltaTime, 0, 0);

        //Rotate Y Direction
       // transform.Rotate(0,1 * -RotateSpeed * Time.deltaTime, 0);

        //Rotate Y Direction
        //transform.Rotate(0,0, 1 * RotateSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1 * -RotateSpeed * Time.deltaTime, 0);
            transform.Translate(1 * speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 1 * RotateSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0,1 * -RotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, 1 * RotateSpeed * Time.deltaTime);
        }
    }
}
