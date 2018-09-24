using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPerameters4 : MonoBehaviour {


	void Start () 
	{
		Shoot (123);
	}
	

	void Update () 
	{
		
	}
	void Shoot ( int data) 
	{
		Debug.Log ("Shooting");
		Debug.Log (data);
	}


}
