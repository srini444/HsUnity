using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjects : MonoBehaviour {

	public float rotateSpeed;
	void Start () 
	{
		
	}
	

	void Update () 
	{
		transform.Rotate (0, rotateSpeed*Time.deltaTime, 0);
	}
}
