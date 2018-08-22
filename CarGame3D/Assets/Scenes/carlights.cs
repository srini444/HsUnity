using UnityEngine;
using System.Collections;

public class carlights : MonoBehaviour {

	public Renderer brakelights;
	public Material brakelightON;
	public Material brakelightOFF;

	public Renderer headlightLeft;
    public Renderer headlightRight;
    public Material headlightsON;
	public Material headlightsOFF;

	
	public Light spotlightLEFT;
	public Light spotlightRIGHT;

    public Light BrSpotlightLEFT;
    public Light BrSpotlightRIGHT;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//braking//
		if(Input.GetKey(KeyCode.Space))
		{
			brakelights.material = brakelightON;
            BrSpotlightLEFT.intensity = 8;
            BrSpotlightRIGHT.intensity = 8f;
        }
		//not braking//
		else
		{
			brakelights.material = brakelightOFF;
            BrSpotlightLEFT.intensity = 0f;
            BrSpotlightRIGHT.intensity = 0f;
        }

		//headlights on/off//
		if(Input.GetKeyDown("1"))
		{
            headlightLeft.material = headlightsON;
            headlightRight.material = headlightsON;
            spotlightLEFT.intensity = 30f;
			spotlightRIGHT.intensity = 30f;
		}
		if(Input.GetKeyDown("2"))
		{
            headlightLeft.material = headlightsOFF;
            headlightRight.material = headlightsOFF;
            spotlightLEFT.intensity = 0f;
			spotlightRIGHT.intensity = 0f;
		}

	}
}









