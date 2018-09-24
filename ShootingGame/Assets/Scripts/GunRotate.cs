using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotate : MonoBehaviour {
	Vector3 gunpos;
	public float GunRouondSpeed;
	public GameObject Gun;


	void Start () 
	{
		
	}
	

	void Update () 
	{

		//gunpos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

	//	transform.LookAt (gunpos);

		//transform.RotateAround (Gun.transform.position, Vector3.up, GunRouondSpeed * Time.deltaTime);
		//GunAround ();
	}

	public void GunAround ()
	{
		
	}

}
