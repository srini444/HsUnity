using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test12TransformComponent : MonoBehaviour {
	
	Vector3 tempPos;
	void Start () 
	{
		
	}
	

	void Update () 
	{
		tempPos = transform.position;

		tempPos.x += 1f * Time.deltaTime;

		transform.position = tempPos;
	}
}
