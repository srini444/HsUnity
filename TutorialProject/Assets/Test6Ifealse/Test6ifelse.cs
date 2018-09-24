using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6ifelse : MonoBehaviour 
{

	int life = 5;
	void Start () 
	{
		life = 2;
	}

	void Update () 
	{
		if (life < 1) 
		{
			Debug.Log ("Game Over");
		} 

		else if (life > 5 && life <= 10) 
		{
			Debug.Log ("Super Power");
		} 

		else if (life > 10 && life <= 15) 
		{
			Debug.Log ("Ultra Power");
		}

		else
		{
			Debug.Log ("Playing");
		}

	}



}
