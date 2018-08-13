using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour {

    public float speed = 10f;
	void Update ()
    {
       // transform.Rotate(speed * Time.deltaTime, 0, 0);
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed; 
    }
}
