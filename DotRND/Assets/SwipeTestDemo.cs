using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTestDemo : MonoBehaviour {

    public GameObject Player;

    public float maxTime;
    public float minSwipeDist;

    float startTime;
    float endTime;

    Vector3 startPos;
    Vector3 endPos;

    float swipeDistance;
    float swipeTime;

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                startTime = Time.time;
                startPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTime = Time.time;
                endPos = touch.position;

                swipeDistance = (endPos - startPos).magnitude;
                swipeTime = endTime - startTime;

                if(swipeTime<maxTime && swipeDistance > minSwipeDist)
                {
                    swipe();
                }
            }
        }


	}

    void swipe()
    {
        Vector3 distance = endPos - startPos;
        if( Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
        {
            Debug.Log("Horizontal Swipe");

            if (distance.x > 0)
            {
                Debug.Log("Right Swipe");
               // Player.GetComponent<playerMove>().JumpX();
            }
            if (distance.x < 0)
            {
                Debug.Log("Left Swipe");
           //     Player.GetComponent<playerMove>().JumpX();
            }

        }

        else if (Mathf.Abs(distance.x) < Mathf.Abs(distance.y))
        {
            Debug.Log("Vertical Swipe");

            if (distance.y > 0)
            {
                Debug.Log("Up Swipe");
                Player.GetComponent<playerMove>().Jump();

            }
            if (distance.y < 0)
            {
                Debug.Log("Down Swipe");
                Player.GetComponent<playerMove>().Jump();
            }

        }
    }
}
