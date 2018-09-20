using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour {

	public float earthSpeed;
	public float earthRouondSpeed;
	public float moonRouondSpeed;
	public GameObject earth;
	public GameObject moon;

	void Start () 
	{
		
	}


	void Update () 
	{
		EarthAround ();
		MoonAround ();
		transform.Rotate (0, earthSpeed+Time.deltaTime, 0, Space.World);
		transform.Rotate (0, earthSpeed+Time.deltaTime, 0, Space.World);
	}

	public void EarthAround ()
	{
		transform.RotateAround (earth.transform.position, Vector3.up, earthRouondSpeed * Time.deltaTime);
	}

	public void MoonAround ()
	{
		transform.RotateAround (earth.transform.position, Vector3.up, moonRouondSpeed * Time.deltaTime);
	}
}
