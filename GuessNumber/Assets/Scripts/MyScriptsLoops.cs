using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptsLoops : MonoBehaviour {


	void Start () 
	{
		for(int i=0 ; i<10 ; i++)
		{
			Debug.Log ("Printed for Loop " + i);
		}

		int a = 0;

		while (a < 10) 
		{
			Debug.Log ("Printed " + a);
			a++;
		}

	}
	

	void Update () 
	{
		
	}
}
