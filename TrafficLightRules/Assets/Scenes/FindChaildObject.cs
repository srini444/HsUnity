using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindChaildObject : MonoBehaviour {

	public GameObject findme;
	public GameObject findmechild;
	public GameObject Cube;


	void Start () 
	{
		


	}

	void Update()
	{
		findme = transform.Find ("FindMe").gameObject;
		findmechild = transform.Find ("FindMe/Cube").gameObject;
		findme.transform.Rotate (0, 1, 0);
	}

}
