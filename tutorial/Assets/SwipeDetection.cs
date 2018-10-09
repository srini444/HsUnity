using UnityEngine;
using System.Collections;

public enum Swipe
{
    None,
    Up,
    Down,
    Left,
    Right
}
;

public class SwipeDetection : MonoBehaviour
{
    public float minSwipeLength = 50f;
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
    public Transform playerPrefab;
    public float timeLeft = 100;

    // static so that refence to this script is not needed by other scripts
    public static Swipe swipeDirection;

    void Update()
    {
        DetectSwipe();
        Debug.Log(swipeDirection);
    }

    public void DetectSwipe()
    {

        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Began)
            {
                firstPressPos = new Vector2(t.position.x, t.position.y);
            }

            if (t.phase == TouchPhase.Ended)
            {
                secondPressPos = new Vector2(t.position.x, t.position.y);
                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

                // Make sure it was a legit swipe, not a tap
                if (currentSwipe.magnitude < minSwipeLength)
                {
                    swipeDirection = Swipe.None;
                    return;
                }

                currentSwipe.Normalize();

                // Swipe up
                if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    swipeDirection = Swipe.Up;
                    Debug.Log("Swiped UP");
                    //playerPrefab.Translate(0,1,0);
                }
                // Swipe down
                else if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    swipeDirection = Swipe.Down;
                    Debug.Log("Swiped DOWN");
                    //playerPrefab.Translate(0,-1,0);

                }
                // Swipe left
                else if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    swipeDirection = Swipe.Left;
                    Debug.Log("Swiped LEFT");
                    //playerPrefab.Translate(-1,0,0);

                }
                // Swipe right
                else if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    swipeDirection = Swipe.Right;
                    Debug.Log("Swiped RIGHT");

                    //playerPrefab.Translate(1,0,0);
                }
            }
        }
        else
        {
            swipeDirection = Swipe.None;
        }

    }
}