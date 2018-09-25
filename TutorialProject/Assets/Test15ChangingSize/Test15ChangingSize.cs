using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test15ChangingSize : MonoBehaviour {

	public float speed = 5;
	Vector3 temp;
	void Start () 
	{
		
	}
	

	void Update () 
	{
		temp = transform.localScale;

		temp.x += 1f*Time.deltaTime;
		//temp.y += 1f*Time.deltaTime;

		transform.localScale = temp;

	}
}
