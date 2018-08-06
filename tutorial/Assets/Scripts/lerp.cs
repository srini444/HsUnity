using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerp : MonoBehaviour {

    Vector3 initialPos, finalPos;
    float timer = 0;
	
	void Start () {
        initialPos = transform.position;
        finalPos = new Vector3(transform.position.x + 10, transform.position.y, transform.position.z);

	}

	void Update () {

        transform.position = Vector3.Lerp(initialPos, finalPos,timer);

        timer += Time.deltaTime;

        if (timer >= 1)
        {
            Vector3 temp = finalPos ;
            finalPos = initialPos;
            initialPos = temp;
            timer = 0;
        }

	}
}
