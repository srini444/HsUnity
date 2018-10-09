using UnityEngine;
using System.Collections;

public class MoveWithSwipe : MonoBehaviour
{

    // Use this for initialization

    //what to move
    public Transform playerPrefab;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movePlayer(SwipeDetection.swipeDirection);
    }

    public void movePlayer(Swipe swipeDirection)
    {
        switch (swipeDirection)
        {
            case Swipe.Up:
                playerPrefab.Translate(0, 1, 0);
                Debug.Log("Move UP");
                break;
            case Swipe.Down:
                playerPrefab.Translate(0, -1, 0);
                Debug.Log("Move DOWN");
                break;
            case Swipe.Right:
                playerPrefab.Translate(1, 0, 0);
                Debug.Log("Move RIGHT");
                break;
            case Swipe.Left:
                playerPrefab.Translate(-1, 0, 0);
                Debug.Log("Move LEFT");
                break;
            case Swipe.None:
                break;
        }
    }

}