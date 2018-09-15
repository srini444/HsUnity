using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour {

	float earthSpeed = 0.5f;

	void Start () 
	{
		
	}


	void Update () 
	{
		transform.Rotate (0, earthSpeed+Time.deltaTime, 0, Space.World);

	}

}
