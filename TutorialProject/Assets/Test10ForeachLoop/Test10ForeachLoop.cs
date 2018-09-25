using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test10ForeachLoop : MonoBehaviour {

	public int[] arr;
	void Start () 
	{
		foreach (int i in arr) 
		{
			Debug.Log (i);
		}
			
	}
	

	void Update () 
	{
		
	}
}
