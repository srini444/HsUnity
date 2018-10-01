using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour {


	public GameObject target;
	void Update () 
	{
		transform.LookAt (target.transform, Vector3.up);
		transform.position = Vector3.Lerp (transform.position, target.transform.position, 0.001f);
	}
}
