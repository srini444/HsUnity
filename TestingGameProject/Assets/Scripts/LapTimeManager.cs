using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapTimeManager : MonoBehaviour {

	public static int MinCount;
	public static int SceCount;
	public static float MilliCount;
	public static string MilliDispaly;

	public GameObject MinBox;
	public GameObject SecBox;
	public GameObject MilliBox;

	void Update () 
	{
	
		MilliCount += Time.deltaTime * 10;
		MilliDispaly = MilliCount.ToString ("F0");
		MilliBox.GetComponent<Text> ().text = "" + MilliDispaly;

		if (MilliCount >= 10) 
		{
			MilliCount = 0;
			SceCount += 1;
		}
		if (SceCount <= 9) 
		{

			SecBox.GetComponent<Text> ().text = "0" + SceCount + ".";
		} 

		else 
		{
			SecBox.GetComponent<Text> ().text = "" + SceCount + ".";
		}

		if (SceCount >= 60) 
		{
			SceCount = 0;
			MinCount += 1;
		}

		if (MinCount <= 9) 
		{

			MinBox.GetComponent<Text> ().text = "0" + MinCount + ":";
		} 

		else 
		{
			MinBox.GetComponent<Text> ().text = "" + MinCount + ":";
		}


	}
}
