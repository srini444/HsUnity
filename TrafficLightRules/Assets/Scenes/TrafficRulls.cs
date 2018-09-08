using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficRulls : MonoBehaviour 
{

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

	bool level1, level2, level3;

	float timer = 0;
	void Start()
	{
		/*Red = transform.Find ("Red").gameObject;
		Yellow = transform.Find ("Yellow").gameObject;
		Green = transform.Find ("Green").gameObject;

		Red = Red.GetComponent<Renderer> ();
		Yellow = Yellow.GetComponent<Renderer>();
		Green = Green.GetComponent<Renderer>();
		*/
	}

	void Update()
	{





	}

}
