using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplect : MonoBehaviour {

	public GameObject LapComplectTrig;
	public GameObject HalfPointTrig;

	public GameObject MinDisplay;
	public GameObject SecDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;

	void OnTriggerEnter()
	{
		if (LapTimeManager.SceCount <= 9) 
		{
			SecDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.SceCount + ".";
		}

		else
		{
			SecDisplay.GetComponent<Text> ().text = "" + LapTimeManager.SceCount + ".";
		}


		if (LapTimeManager.MinCount <= 9) 
		{
			MinDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.MinCount + ".";
		}

		else
		{
			MinDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MinCount + ".";
		}

		MilliDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MilliCount;

		LapTimeManager.MinCount = 0;
		LapTimeManager.SceCount = 0;
		LapTimeManager.MilliCount = 0;

		HalfPointTrig.SetActive (true);
		LapComplectTrig.SetActive (false);
	}
}
