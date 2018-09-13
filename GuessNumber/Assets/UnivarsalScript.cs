using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnivarsalScript : MonoBehaviour {

	Animator anim;
	Rigidbody2D rb;
	void Start () 
	{
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();

		UnivarsalScript script = GetComponent<UnivarsalScript> ();
	}
	

	void Update () 
	{
		

	}
}
