using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test14RotatingObjectstransformRotate : MonoBehaviour {

	public float speed = 5;
	void Start () 
	{
		
	}
	

	void Update () 
	{
		transform.Rotate (speed, 0, 0);
	}
}
