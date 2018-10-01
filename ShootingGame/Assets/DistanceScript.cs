using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceScript : MonoBehaviour {


	public GameObject target;
	public GameObject enemy;
	public float Distance_;
	void Update () 
	{
		
		Distance_ = Vector3.Distance(enemy.transform.position,transform.position);
		if (Distance_ < 12) 
		{
			transform.LookAt (target.transform);
			transform.position = Vector3.MoveTowards (transform.position, enemy.transform.position,  Time.deltaTime);
		}
	}
}
