using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "Red":
                ScoreTracker.UpdateScore(1);
                ScoreTracker.UpdateMessage("You Socred 1 Point");
                break;
            case "Green":
                ScoreTracker.UpdateScore(2);
                ScoreTracker.UpdateMessage("You Socred 2 Point");
                break;
            case "Blue":
                ScoreTracker.UpdateScore(3);
                ScoreTracker.UpdateMessage("You Socred 3 Point");
                break;
            case "Yellow":
                ScoreTracker.UpdateScore(4);
                ScoreTracker.UpdateMessage("You Socred 4 Point");
                break;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        switch (col.gameObject.tag)
        {
            case "Red":
                break;
            case "Green":
                break;
            case "Blue":
                break;
            case "Yellow":
                break;
        }
    }

}
