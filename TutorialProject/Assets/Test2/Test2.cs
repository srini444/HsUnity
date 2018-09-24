using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {
	int a = 5;
	float b= 5.5f;
	string myName = "Srinivas";

	void Start () 
	{
		Debug.Log (a);
		Debug.Log (b);
		Debug.Log (myName);
		Debug.Log (a + b + myName);
	}
	

	void Update () 
	{
		
	}
}
