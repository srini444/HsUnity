using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptCorotien : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//StartCoroutine (printsomething ());
		StartCoroutine ("printsomething"); 
	}
	

	IEnumerator printsomething()
	{
		yield return new WaitForSeconds (2f);
		Debug.Log ("Waitted 2 Sec");
	}

	void Update () 
	{
		
	}
}
