using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CountDown : MonoBehaviour {


	public GameObject Countdown;
	public AudioSource GetReady;
	public AudioSource Go;
	public GameObject LapTimer;
	//public GameObject CarControls;
	public GameObject CarUserControl;


	void Start () 
	{
		StartCoroutine (CountStart ());
		CarUserControl.GetComponent<CarUserControl>().enabled = false;
	}
	
	IEnumerator CountStart()
	{
		//CarControls.SetActive (false);

		yield return new WaitForSeconds (0.5f);
		Countdown.GetComponent<Text>().text = "3";
		GetReady.Play ();
		Countdown.SetActive (true);
		yield return new WaitForSeconds (1);


		Countdown.SetActive (false);
		Countdown.GetComponent<Text>().text = "2";
		GetReady.Play ();
		Countdown.SetActive (true);
		yield return new WaitForSeconds (1);

		Countdown.SetActive (false);
		Countdown.GetComponent<Text>().text = "1";
		GetReady.Play ();
		Countdown.SetActive (true);
		yield return new WaitForSeconds (1);
		Countdown.SetActive (false);

		Go.Play ();
		LapTimer.SetActive (true);
		//CarControls.SetActive (true);
		CarUserControl.GetComponent<CarUserControl>().enabled = true;

		yield return null;
	}

}


