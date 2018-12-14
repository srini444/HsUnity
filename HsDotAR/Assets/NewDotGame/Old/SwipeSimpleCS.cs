using UnityEngine;
using System.Collections;

public class SwipeSimpleCS : MonoBehaviour
{

    public Transform player; // Drag your player here
    private Vector2 fp; // first finger position
    private Vector2 lp; // last finger position
    private float angle;
    private float swipeDistanceX;
    private float swipeDistanceY;
    Rigidbody rb;

    public GameObject dotPrefab;
    GameObject dotInsstance;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        CreateDot();
    }

    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fp = touch.position;
                lp = touch.position;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                lp = touch.position;
                swipeDistanceX = Mathf.Abs((lp.x - fp.x));
                swipeDistanceY = Mathf.Abs((lp.y - fp.y));
            }
            if (touch.phase == TouchPhase.Ended)
            {
                angle = Mathf.Atan2((lp.x - fp.x), (lp.y - fp.y)) * 57.2957795f;

                if (angle > 60 && angle < 120 && swipeDistanceX > 40)
                {
                    print("right");
                    player.Rotate(0, 45, 0);
                }
                if (angle > 150 || angle < -150 && swipeDistanceY > 40)
                {
                    print("down");
                    player.position += new Vector3(0, -2, 0);
                }
                if (angle < -60 && angle > -120 && swipeDistanceX > 40)
                {
                    print("left");
                    player.Rotate(0, -45, 0);
                }
                if (angle > -30 && angle < 30 && swipeDistanceY > 40)
                {
                    print("up");
                    player.position += new Vector3(0, 2, 0);
                    rb.AddForce(new Vector3(0f, 5f, 12f));
                    
                }
            }
        }
    }
    void CreateDot()
    {
        dotInsstance = Instantiate(dotPrefab, dotPrefab.transform.position, dotPrefab.transform.rotation) as GameObject;
    }
}