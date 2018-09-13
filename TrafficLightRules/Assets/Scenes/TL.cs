using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TL : MonoBehaviour {

	public GameObject TL1;
   


	public GameObject Red;
	public GameObject Yellow;
	public GameObject Green;


	public Renderer redLight;
	public Renderer yellowLight;
	public Renderer greenLight;

	public Color brightRed;
	public Color dullRed;


	public Color brightYellow;
	public Color dullYellow;

	public Color brightGreen;
	public Color dullGreen;

	float timer = 5;
	bool level1, level2, level3;

	void Start () 
	{
		
	}
	

	void Update ()
	{


		TL1 = transform.Find ("TL1").gameObject;



		timer += Time.deltaTime;

		if (timer > 5 && timer < 10 && level1 == false) 
		{
			transform.Find ("TL1/Red").GetComponent<Renderer> ().material.color = brightRed;
			transform.Find ("TL1/Yellow").GetComponent<Renderer> ().material.color = dullYellow;
			transform.Find ("TL1/Green").GetComponent<Renderer> ().material.color = dullGreen;


			transform.Find ("TL1/Red1").GetComponent<Renderer> ().material.color = dullRed;
			transform.Find ("TL1/Yellow1").GetComponent<Renderer> ().material.color = brightYellow;
			transform.Find ("TL1/Green1").GetComponent<Renderer> ().material.color = dullGreen;

			transform.Find ("TL1/Red2").GetComponent<Renderer> ().material.color = dullRed;
			transform.Find ("TL1/Yellow2").GetComponent<Renderer> ().material.color = dullYellow;
			transform.Find ("TL1/Green2").GetComponent<Renderer> ().material.color = brightGreen;


			transform.Find ("TL1/Red3").GetComponent<Renderer> ().material.color = dullRed;
			transform.Find ("TL1/Yellow3").GetComponent<Renderer> ().material.color = dullYellow;
			transform.Find ("TL1/Green3").GetComponent<Renderer> ().material.color = brightGreen;


			level1 = true;
		} 

		else if (timer > 10 && timer < 15 && level2 == false) 
		{
			transform.Find ("TL1/Red").GetComponent<Renderer> ().material.color = brightRed;
			transform.Find ("TL1/Yellow").GetComponent<Renderer> ().material.color = dullYellow;
			transform.Find ("TL1/Green").GetComponent<Renderer> ().material.color = dullGreen;

			transform.Find ("TL1/Red1").GetComponent<Renderer> ().material.color = dullRed;
			transform.Find ("TL1/Yellow1").GetComponent<Renderer> ().material.color = brightYellow;
			transform.Find ("TL1/Green1").GetComponent<Renderer> ().material.color = dullGreen;

			transform.Find ("TL1/Red2").GetComponent<Renderer> ().material.color = dullRed;
			transform.Find ("TL1/Yellow2").GetComponent<Renderer> ().material.color = brightYellow;
			transform.Find ("TL1/Green2").GetComponent<Renderer> ().material.color = dullGreen;



			transform.Find ("TL1/Red3").GetComponent<Renderer> ().material.color = brightRed;
			transform.Find ("TL1/Yellow3").GetComponent<Renderer> ().material.color = brightYellow;
			transform.Find ("TL1/Green3").GetComponent<Renderer> ().material.color = brightGreen;
		//	level2 == true;
		

		}

		else if (timer > 15 ) 
		{
			transform.Find ("TL1/Red").GetComponent<Renderer> ().material.color = dullRed;
			transform.Find ("TL1/Yellow").GetComponent<Renderer> ().material.color = brightYellow;
			transform.Find ("TL1/Green").GetComponent<Renderer> ().material.color = dullGreen;

			transform.Find ("TL1/Red1").GetComponent<Renderer> ().material.color = brightRed;
			transform.Find ("TL1/Yellow1").GetComponent<Renderer> ().material.color = dullYellow;
			transform.Find ("TL1/Green1").GetComponent<Renderer> ().material.color = brightGreen;

			transform.Find ("TL1/Red2").GetComponent<Renderer> ().material.color = brightRed;
			transform.Find ("TL1/Yellow2").GetComponent<Renderer> ().material.color = dullYellow;
			transform.Find ("TL1/Green2").GetComponent<Renderer> ().material.color = brightGreen;


			transform.Find ("TL1/Red3").GetComponent<Renderer> ().material.color = dullRed;
			transform.Find ("TL1/Yellow3").GetComponent<Renderer> ().material.color = brightYellow;
			transform.Find ("TL1/Green3").GetComponent<Renderer> ().material.color = dullGreen;

			level1 = false;
			level2 = false;
			timer = 0;
		}

	
	}
}
