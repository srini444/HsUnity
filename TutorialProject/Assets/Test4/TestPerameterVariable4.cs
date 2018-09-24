using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPerameterVariable4 : MonoBehaviour {


	void Start () 
	{
		int a= Shoot (12);
		Debug.Log (a);
	}
	

	void Update () 
	{
		
	}

	int Shoot(int data)
	{
		Debug.Log ("Shooting");
		Debug.Log (data);
		return (data * 2);

	}

}
