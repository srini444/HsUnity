using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObjects : MonoBehaviour {

	public float moveSpeed;
	void Start () 
	{
		
	}
	

	void Update () 
	{
		
		transform.Translate (0, 0, 0.2f*moveSpeed*Time.deltaTime);

	}
}
