using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThowBall : MonoBehaviour {
    
    [Header("Presonalize object speed")]
    public float MaxObjectSpeed = 40;

    [Space(10)]
    [Header("Flick Speed")]
    public float FlickSpeed = 0.4f;


    public string respawnName = "";
    public float howClose = 9.0f;
    float startTime, endTime, swipeDistance, swipeTime;
    Vector2 startPos;
    Vector2 endPos;
    float tempTime;

    float FlickLenght;
    float ObjectVelocity = 0;
    float ObjectSpeed = 0;
    Vector3 angle;

    bool thrown, holding;
    Vector3 newPosition, varlocity;



    void Start ()
    {
        this.GetComponent<Rigidbody>().useGravity = false;
	}
	
	void OnTouch()
    {
        Vector3 mousePos = Input.GetTouch(0).position;
        mousePos.z = Camera.main.nearClipPlane * howClose;
        newPosition = Camera.main.ScreenToViewportPoint(mousePos);
        this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, newPosition, 80f * Time.deltaTime);
    }

	void Update ()
    {
        if (holding)
        {
            OnTouch();
        }
        else if (thrown)
        {
            return;
        }

        else 
        {
            
        }

        if (Input.touchCount > 0)
        {
            Touch _touch = Input.GetTouch(0);
            if(_touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if(Physics.Raycast(ray,out hit ,100f))
                {
                    if(hit.transform == this.transform)
                    {
                        startTime = Time.time;
                        startPos = _touch.position;
                        holding = true;
                        transform.SetParent(null);
                    }
                   
                }
            }
            else if(_touch.phase == TouchPhase.Ended&& holding)
            {
                endTime = Time.time;
                endPos = _touch.position;
                swipeDistance = (endPos - startPos).magnitude;
                swipeTime = endTime - startTime;

                if (swipeTime<FlickSpeed && swipeDistance > 100f)
                {
                    CalSpeed();
                    MoveAngle();
                    this.GetComponent<Rigidbody>().AddForce(new Vector3((angle.x * ObjectSpeed), (angle.y * ObjectSpeed), (angle.z * ObjectSpeed)));
                    this.GetComponent<Rigidbody>().useGravity = true;
                    holding = false;
                    thrown = true;
                    Invoke("_Reset", 3f);
                }
                else
                {
                    _Reset();
                }
            }
            if (startTime > 0)
                tempTime = Time.time - startTime;
            if (tempTime > FlickSpeed)
            {
                startTime = Time.time;
                startPos = _touch.position;
            }
        }
	}

    void _Reset()
    {
        Transform ReSpwanPoint = GameObject.Find(respawnName).transform;
        this.gameObject.transform.position = ReSpwanPoint.position;
        this.gameObject.transform.rotation = ReSpwanPoint.rotation;
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        this.GetComponent<Rigidbody>().useGravity = false;
        thrown = holding = false;
    }

    void CalSpeed()
    {
        FlickLenght = swipeDistance;
        if (swipeTime > 0)
        {
            ObjectVelocity = FlickLenght / (FlickLenght - swipeTime);

        }
        ObjectSpeed = ObjectVelocity * 50;
        ObjectSpeed = ObjectSpeed - (ObjectSpeed * 1.7f);
        if(ObjectSpeed<= -MaxObjectSpeed)
        {
            ObjectSpeed = -MaxObjectSpeed;
        }
        swipeTime = 0;
    }

    void MoveAngle()
    {
        angle = Camera.main.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(endPos.y, 50f, (Camera.main.GetComponent<Camera>().nearClipPlane - howClose)));
    }
}
