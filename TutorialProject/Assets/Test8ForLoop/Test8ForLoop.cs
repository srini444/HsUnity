using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test8ForLoop : MonoBehaviour {

	int i = 1;
	void Start () 
	{
		while (i < 6) 
		{
			Debug.Log ("The value of i:  " + i);
			i++;
		}
		Debug.Log ("Out for the While Loop");


		for(i= 1 ; i< 6; i++)
		{
			Debug.Log ("The value of i :" + i);
		}
		Debug.Log ("Out for Looop");
	}



	void Update () 
	{
		
	}
}
