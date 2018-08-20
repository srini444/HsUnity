using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carScript : MonoBehaviour {

    public float speed = 10; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Car Move Forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x + Time.deltaTime * speed,transform.position.y, transform.position.z);
        }

        //Car Move Back
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x - Time.deltaTime * speed, transform.position.y, transform.position.z);
        }

        //Car Move RightSide
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Time.deltaTime * speed);
        }

        //Car Move LeftSide
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + Time.deltaTime * speed);
        }


        // Tommrow Rotate Wheels

      
    }
}
