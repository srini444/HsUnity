using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPoinTrigger : MonoBehaviour {

	public GameObject LapComplectTrig;
	public GameObject HalfPoinTrig;

	void OnTriggerEnter()
	{
		LapComplectTrig.SetActive (true);
		HalfPoinTrig.SetActive (false);
	}

}
