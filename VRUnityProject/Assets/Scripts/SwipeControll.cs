using UnityEngine;
using System.Collections;

public class SwipeControll : MonoBehaviour
{
    public bool Active = true;

    public bool SwipeVertical = true;
    public bool SwipeHorizontal = true;

    public float minSwipeDistY;
    public float minSwipeDistX;
    [HideInInspector]
    public bool HitSwipe = false;
    protected Vector2 startPos;



    public virtual void ActionUpSwipe()
    {
        //Debug.Log("Swipe Up");
    }

    public virtual void ActionDownSwipe()
    {
        //Debug.Log("Swipe Down");
    }

    public virtual void ActionRightSwipe()
    {
        //Debug.Log("Swipe Right");
    }

    public virtual void ActionLefthSwipe()
    {
        //Debug.Log("Swipe Lefth");
    }

    protected void Update()
    {

#if UNITY_EDITOR

        if (Input.GetKeyDown(KeyCode.UpArrow))
            ActionUpSwipe();
        if (Input.GetKeyDown(KeyCode.DownArrow))
            ActionDownSwipe();
        if (Input.GetKeyDown(KeyCode.RightArrow))
            ActionRightSwipe();
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            ActionLefthSwipe();
#endif

        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;

                case TouchPhase.Ended:

                    float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;
                    float swipeDistHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;

                    if (swipeDistVertical > minSwipeDistY && SwipeVertical)
                    {
                        float swipeValue = Mathf.Sign(touch.position.y - startPos.y);

                        if (swipeValue > 0)//up swipe
                            ActionUpSwipe();
                        else if (swipeValue < 0)//down swipe
                            ActionDownSwipe();
                    }

                    if (swipeDistHorizontal > minSwipeDistX && SwipeHorizontal)
                    {
                        float swipeValue = Mathf.Sign(touch.position.x - startPos.x);

                        if (swipeValue < 0)
                            ActionRightSwipe();
                        else if (swipeValue > 0)
                            ActionLefthSwipe();
                    }

                    break;
            }
        }
    }

}
