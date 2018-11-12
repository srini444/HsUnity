using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreTracker : MonoBehaviour {

    static Text scoreText;
    static Text messageText;
    static int curentScore = 0;
    static string curentMessage = "Lets play";

	void Start ()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        messageText = GameObject.Find("MessageText").GetComponent<Text>();
        UpdateScore(curentScore);
        UpdateMessage(curentMessage);
    }

    public static void UpdateScore(int addedValue)
    {
        curentScore += addedValue;
        scoreText.text = "Score : " + curentScore;
    }

    public static void UpdateMessage(string message)
    {
        curentMessage = message;
        messageText.text = curentMessage;
    }
}
