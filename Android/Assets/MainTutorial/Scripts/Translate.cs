using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{

    public float speed = 5f;
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        // Move Player X Direction 
        // transform.Translate(1*speed*Time.deltaTime, 0, 0);

        // Move Player Y Direction 
       

        // Move Player Z Direction 
        // transform.Translate(0,0,1 * speed * Time.deltaTime);


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1 * speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(1 * -speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,1 * speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 1 * -speed * Time.deltaTime, 0);
        }

    }

}
