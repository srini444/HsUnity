using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour {

	
	void Start ()
    {
        

        
	}
	
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Animator cubeAnimation = GameObject.Find("Cube").GetComponent<Animator>();
            cubeAnimation.speed = 1;
        }

    }
}
