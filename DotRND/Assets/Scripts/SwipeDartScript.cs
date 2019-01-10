﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwipeDartScript : MonoBehaviour
{
    private Vector3 fingerDown;
    private Vector3 fingerUp;
    public bool detectSwipeOnlyAfterRelease = false , col;

    public float SWIPE_THRESHOLD = 10f;
    Rigidbody rb;

    private Vector3 originalPosition;
    private Quaternion originalRotation;

    public float speed = 5f;

    public Text countText;
    private int count;
    //GameObject Board;
    //public float Boardspeed = 10f ;
    GameObject Triangle;

    void Awake()
    {
        this.originalPosition = this.transform.position;
        this.originalRotation = this.transform.rotation;
    }

    void Start()
    {
        //StartCoroutine(resetTransform());
        count = 0;
        SetCount();
        rb = GetComponent<Rigidbody>();
        //Board = GameObject.Find("Board");
        // Triangle = GameObject.Find("Triangle");
        //originalPos = gameObject.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Board.transform.Rotate(-10f* Boardspeed * Time.deltaTime, 0f, 0f);
        //Triangle.transform.Rotate(-10f * Boardspeed * Time.deltaTime, 0f, 0f);
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fingerUp = touch.position;
                fingerDown = touch.position;
            }

            //Detects Swipe while finger is still moving
            if (touch.phase == TouchPhase.Moved)
            {
                if (!detectSwipeOnlyAfterRelease)
                {
                    fingerDown = touch.position;
                    checkSwipe();
                }
            }

            //Detects swipe after finger is released
            if (touch.phase == TouchPhase.Ended)
            {
                fingerDown = touch.position;
                checkSwipe();             
            }
        }
    }

    void checkSwipe()
    {
        
        //Check if Vertical swipe
        if (verticalMove() > SWIPE_THRESHOLD && verticalMove() > horizontalValMove())
        {
            //Debug.Log("Vertical");
            if (fingerDown.y - fingerUp.y > 0)//up swipe
            {
                OnSwipeUp();
            }
            else if (fingerDown.y - fingerUp.y < 0)//Down swipe
            {
                OnSwipeDown();
            }
            fingerUp = fingerDown;
        }

        //Check if Horizontal swipe
        else if (horizontalValMove() > SWIPE_THRESHOLD && horizontalValMove() > verticalMove())
        {
            //Debug.Log("Horizontal");
            if (fingerDown.x - fingerUp.x > 0)//Right swipe
            {
                OnSwipeRight();
            }
            else if (fingerDown.x - fingerUp.x < 0)//Left swipe
            {
                OnSwipeLeft();
            }
            fingerUp = fingerDown;
        }

        //No Movement at-all
        else
        {
            Debug.Log("No Swipe!");          
        }
    }

    float verticalMove()
    {
        return Mathf.Abs(fingerDown.y - fingerUp.y);
    }

    float horizontalValMove()
    {
        return Mathf.Abs(fingerDown.x - fingerUp.x);
    }

    //////////////////////////////////CALLBACK FUNCTIONS/////////////////////////////
    void OnSwipeUp()
    {
        Debug.Log("Swipe UP");
        rb.AddForce(new Vector3 (Random.Range(-1.5f, 1.5f), Random.Range(4f , 8f), 15f)*speed*Time.deltaTime, ForceMode.Impulse);
        StartCoroutine(resetTransform());
    }

    void OnSwipeDown()
    {
        Debug.Log("Swipe Down");
    }

    void OnSwipeLeft()
    {
        Debug.Log("Swipe Left");
        rb.AddForce(new Vector3( Random.Range(-3f, 0f), 5f, 15f)*speed * Time.deltaTime, ForceMode.Impulse);
    }

    void OnSwipeRight()
    {
        Debug.Log("Swipe Right");
        rb.AddForce(new Vector3( Random.Range(0f, 3f), 5f, 15f) * speed * Time.deltaTime, ForceMode.Impulse);
    }


    IEnumerator resetTransform()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("Swipe Dectetor");
        rb.isKinematic = false;
        rb.AddForce(Vector3.zero);
        this.transform.position = this.originalPosition;
        this.transform.rotation = this.originalRotation;

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("1"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 1;
            SetCount();
            rb.isKinematic = true;
          //  resetTransform();
        }

        if (other.gameObject.CompareTag("2"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 2;
            SetCount();
           // Destroy(this.gameObject, 3f);
            rb.isKinematic = true;
          //  resetTransform();
        }

        if (other.gameObject.CompareTag("3"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 3;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
            // Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("4"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 4;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
        }

        if (other.gameObject.CompareTag("5"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 5;
            SetCount();
            rb.isKinematic = true;
            //resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("6"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 6;
            SetCount();
            rb.isKinematic = true;
            //resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("7"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 7;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
        }

        if (other.gameObject.CompareTag("8"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 8;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("9"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 9;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
            // Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("10"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 10;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
        }

        if (other.gameObject.CompareTag("11"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 11;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("12"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 12;
            SetCount();
            rb.isKinematic = true;
            //resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("13"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 13;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
            // Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("14"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 14;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("15"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 15;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("16"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 16;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("17"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 17;
            SetCount();
            rb.isKinematic = true;
           // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("18"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 18;
            SetCount();
            rb.isKinematic = true;
            //Destroy(this.gameObject, 3f);
            //resetTransform();
        }

        if (other.gameObject.CompareTag("19"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 19;
            SetCount();
            rb.isKinematic = true;
            //resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("20"))
        {
            col = true;
            Debug.Log(other.gameObject.name);
            count = count + 20;
            SetCount();
            rb.isKinematic = true;
            //Destroy(this.gameObject, 3f);
           // resetTransform();
        }
       
    }

    void SetCount()
    {
        countText.text = "Points: " + count.ToString();
    }

   
   

}