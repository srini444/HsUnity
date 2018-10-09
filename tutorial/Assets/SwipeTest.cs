using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{

    public float maxTime;
    public float minSwipeDistance;

    float startTime;
    float endTime;


    Vector3 startPos;
    Vector3 endPos;
    Vector3 direction;

    float swipeDistance;
    float swipeTime;

    public GameObject Player;

    [Range(0.05f, 1f)]
    public float throwForce = 0.3f;

   
    void Start ()
    {
		
	}
	
	void Update ()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
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

                if (swipeTime < maxTime && swipeDistance > minSwipeDistance)
                {
                    swipe();
                }


            }

        }


    }

    void swipe()
    {
        Vector2 distance = endPos - startPos;
        if (Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
         {
            Debug.Log("Horizontal Swipe");
            if(distance.x > 0)
            {
                Debug.Log("Right Swipe");
            }
            if (distance.x < 0)
            {
                Debug.Log("Left Swipe");
            }

        }

       else if (Mathf.Abs(distance.x) < Mathf.Abs(distance.y))
        {
            Debug.Log("Vertical Swipe");
            if (distance.y > 0)
            {
                Debug.Log("Up Swipe");
                Player.GetComponent<PlayerMove>().Jump(); 

            }
            if (distance.y < 0)
            {
                Debug.Log("Down Swipe");
            }
        }

    }


    void jumpMove()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTime = Time.time;
            startPos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTime = Time.time;
            swipeTime = endTime - startTime;
            endPos = Input.GetTouch(0).position;
            direction = startPos - endPos;
            GetComponent<Rigidbody>().AddForce(-direction / swipeTime * throwForce);
        }


    }

}
