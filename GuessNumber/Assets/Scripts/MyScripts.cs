using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScripts : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
		int speed = 3;
		int maxSpeed = 12;


		switch (speed) 
		{

		case 1:
			Debug.Log ("The Speed is 1");
			break;
		case 2:
			Debug.Log ("The Speed is 2");
			break;
		case 3:
			Debug.Log ("The Speed is 3");
			break;
		case 4:
			Debug.Log ("The Speed is 4");
			break;

		default :
			Debug.Log ("Defalt Excuted");
			break;	

		}




		if(speed == 1)
		{
			Debug.Log ("The else Speed is 1");
		}

		else if(speed == 2)
		{
			Debug.Log ("The else Speed is 2");
		}

		else if(speed == 3)
		{
			Debug.Log ("The else Speed is 3");
		}

		else if(speed == 4)
		{
			Debug.Log ("The else Speed is 4");
		}
		else if(speed == 5)
		{
			Debug.Log ("The else Speed is 5");
		}
		else 
		{
			Debug.Log ("else was excuted");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
