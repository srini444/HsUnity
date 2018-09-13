using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGame : MonoBehaviour {


	//Player warrrior ;
	//Assess Public  

	// Use this for initialization
	void Start () 
	{
//		Player	warrrior = new Player(90,150,"Srinivas");


		Warrrior war = new Warrrior ();

		war.attack();
		war.Attack ();
		war.info ();

	}
	
	// Update is called once per frame
	void Update () {

		// warrrior not public
		//warrrior.info ();
	}
}
