using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEncapsulation : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		NewPlayer p1 = new NewPlayer ();
		Debug.Log ("The Power is : " + p1.GetPower ());

		p1.SetPower (56);

		Debug.Log ("The Power is : " + p1.GetPower ());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
