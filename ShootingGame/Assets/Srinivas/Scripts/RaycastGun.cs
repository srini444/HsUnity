using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGun : MonoBehaviour {

	public float speedH = 2.0f;
	public float speedV = 2.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;

//	public GameObject ball;
//	public GameObject enemies1;
//	public GameObject enemies2;
//	public GameObject enemies3;
//	public GameObject enemies4;


	void Start ()
	{
		
//			for (int t = 0; t < 2; t++)
//			{
//				for (int r = 0; r < 2; r++)
//				{
//				
//
//				//GameObject temp1 = (GameObject)Instantiate(enemies1, new Vector3(-6 + 1.5f * r, -0.47f , 7.5f - 5f * t), Quaternion.identity);
//
//				//GameObject temp2 = (GameObject)Instantiate(enemies2, new Vector3(-14 + 1.5f * r, -0.47f , 7.5f - 5f * t),	Quaternion.identity);
//
//				//GameObject temp3 = (GameObject)Instantiate(enemies3, new Vector3(-10 + 1.5f * r, -0.29f , 7.5f - 5f * t), Quaternion.identity);
//
//				//GameObject temp4 = (GameObject)Instantiate(enemies4, new Vector3(-5 + 1.5f * r, -0.29f , 7.5f - 5f * t), Quaternion.identity);
//
//
//				
//				}
//			}


	}
	void Update () 
	{
		
		yaw += speedH * Input.GetAxis("Mouse X");
		//pitch -= speedV * Input.GetAxis("Mouse Y");

		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

	}
}
