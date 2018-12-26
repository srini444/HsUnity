using UnityEngine;
using System.Collections;

public class DotSwipeDetector : MonoBehaviour
{
    private Vector3 fingerDown;
    private Vector3 fingerUp;
    public bool detectSwipeOnlyAfterRelease = false;

    public float SWIPE_THRESHOLD = 20f;
    Rigidbody rb;
    public float speed = 50f;

    public GameObject dotPrefab;
    GameObject dotInsstance;

    void Start()
    {
        CreateDot();
    }

    // Update is called once per frame
    void Update()
    {

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
                }
            }

            //Detects swipe after finger is released
            if (touch.phase == TouchPhase.Ended)
            {
                fingerDown = touch.position;
                checkSwipe();
                Invoke("CreateDot", 3f);
               
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
            //Debug.Log("No Swipe!");
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


    void OnSwipeUp()
    {
        Debug.Log("Swipe UP");
        dotInsstance.GetComponent<Rigidbody>().AddForce(Random.Range(-1.0f, 1.0f), Random.Range(4f, 8f), 15f, ForceMode.Impulse);            
    }

    void OnSwipeDown()
    {
        Debug.Log("Swipe Down");
    }

    void OnSwipeLeft()
    {
        Debug.Log("Swipe Left");
        dotInsstance.GetComponent<Rigidbody>().AddForce(Random.Range(-3.0f, 0.07f), 5f, 15f, ForceMode.Impulse);
    }

    void OnSwipeRight()
    {
        Debug.Log("Swipe Right");
        dotInsstance.GetComponent<Rigidbody>().AddForce(Random.Range(0.07f, 3f), 5f, 15f, ForceMode.Impulse);        
    }
    public void CreateDot()
    {
        dotInsstance = Instantiate(dotPrefab, dotPrefab.transform.position, Quaternion.identity) as GameObject;
    }


}