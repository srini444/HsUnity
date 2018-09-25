using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test7WhileLoop : MonoBehaviour {

	int i = 2;
	void Start () 
	{

		while(i < 6)
		{
			Debug.Log ("While Loop" + i);
			i++;
		}
		Debug.Log ("Out this while loop");
	}
	
	void Update()
	{
		
	}
		

}
