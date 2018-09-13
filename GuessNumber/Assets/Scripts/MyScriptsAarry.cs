using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptsAarry : MonoBehaviour {

	int[] num = new int[10];
	void Start () 
	{
		

		for(int i = 0; i <num.Length ; i++ )
		{
			num [i] = Random.Range (1,100);

		}

		for(int i = 0; i <num.Length ; i++ )
		{
			
			Debug.Log ("Element:"+ i +"is " + num[i]);
		}

		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
