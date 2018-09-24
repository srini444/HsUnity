using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class1Rotation : MonoBehaviour {

	public float CubeRotationSpeed ;
	void Start () 
	{
		
	}
	

	void Update () 
	{

		transform.Rotate (new Vector3 (CubeRotationSpeed*Time.deltaTime, 0, 0));
		//transform.Rotate (new Vector3 (50, 0, 0));
		Debug.Log ("Rotate Cube");




	}
}
