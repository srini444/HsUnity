using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessNumber : MonoBehaviour {
	public InputField input ;
	public Text infotext;

	private int guessNumber;
	private int userGuess;

	void Start () 
	{
		guessNumber = Random.Range (0, 100);
	}

	public void CheckGuess()
	{
		userGuess = int.Parse (input.text);
		if(userGuess == guessNumber)
		{
			infotext.text ="You Guessed The Number ! Your Are a Wizard";
		}
		else if(userGuess > guessNumber)
		{
			infotext.text ="You Number Is Greater Than The Guess Number";
		}

		else if(userGuess < guessNumber)
		{
			infotext.text ="You Number Is Lower Than The Guess Number";
		}

		input.text = "";
	}


}
