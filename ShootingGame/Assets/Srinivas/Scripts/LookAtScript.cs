using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour {


	public GameObject target;
	//public GameObject enemy;
	public Vector3 InitGORot;
	Vector3 direction;

	void Start()
	{
		InitGORot = transform.eulerAngles;
	}


	void Update () 
	{

		if (Vector3.Distance (transform.position, target.transform.position) > 1.5f) {
			
			transform.LookAt (target.transform.position);
			//transform.position = Vector3.Lerp (transform.position, target.transform.position, 0.001f);

			direction = (target.transform.position - transform.position);
			direction = direction.normalized;
			Debug.Log (direction);

		

			//Vector3.Cross (target.transform.position, transform.position);

			transform.Translate (direction * Time.deltaTime);

			transform.eulerAngles = new Vector3 (InitGORot.x, transform.eulerAngles.y, InitGORot.z);
		}

	}
}
