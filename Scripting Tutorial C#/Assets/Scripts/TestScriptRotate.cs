using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptRotate : MonoBehaviour {

    //  public float speed = 2f;

    // Use this for initialization

    Vector3 temp;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Rotate the Object X axis 
        //      transform.Rotate(speed,0,0);

        // Object position move to  X axis  only
        // transform.Translate(speed * Time.deltaTime, 0, 0);

        //transform.Rotate(0,speed, 0);
        // transform.Rotate(0,0, speed);

        temp = transform.localScale;

        temp.x += Time.deltaTime;

        transform.localScale = temp;
    }
}
