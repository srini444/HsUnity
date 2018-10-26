﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeScript : MonoBehaviour {

	Vector2 startPos, endPos, direction; 
	float touchTimeStart, touchTimeFinish, timeInterval; 

	[SerializeField]
	float throwForceInXandY = 1f; 

	[SerializeField]
	float throwForceInZ = 50f; 

	Rigidbody rb;

    public Text txtScore;
    int Score;
    
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
       
    }

	
	void Update ()
    {

        if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began)
        {
            touchTimeStart = Time.time;
			startPos = Input.GetTouch (0).position;
		}

		
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended)
        {
            touchTimeFinish = Time.time;
            timeInterval = touchTimeFinish - touchTimeStart;
            endPos = Input.GetTouch (0).position;
            direction = startPos - endPos;
            	
			rb.isKinematic = false;
			rb.AddForce (- direction.x * throwForceInXandY, - direction.y * throwForceInXandY, throwForceInZ / timeInterval);
            Destroy (gameObject, 2f);
        }
			
	}


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Score++;
            txtScore.text = "Score : " + Score;
        }
    }
    
}
