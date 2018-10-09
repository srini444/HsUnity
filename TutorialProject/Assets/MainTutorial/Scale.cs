using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour {

    public float increseScaleSpeed =5f;
    Vector3 tempScale;
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        


        if (Input.GetKey(KeyCode.UpArrow))
        {
            tempScale = transform.localScale;
            tempScale.x += 1f *increseScaleSpeed* Time.deltaTime;
            transform.localScale = tempScale;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            tempScale = transform.localScale;
            tempScale.x -= 1f*increseScaleSpeed * Time.deltaTime;
            transform.localScale = tempScale;
        }


    }
}
