using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotate : MonoBehaviour {

	public float GunRouondSpeed;
	public GameObject Gun;


	void Start () 
	{
		
	}
	

	void Update () 
	{
		transform.RotateAround (Gun.transform.position, Vector3.up, GunRouondSpeed * Time.deltaTime);
		//GunAround ();
	}

	public void GunAround ()
	{
		
	}

}
