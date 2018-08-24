using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightOneByOne : MonoBehaviour {

    // Red Light
    public Renderer redLight;

    public Material redLightON;
    public Material redLightOFF;

    // Yellow Light
    public Renderer yellowLight;

    public Material yellowLightON;
    public Material yellowLightOFF;


    bool level1, level2, level3;
    float timer = 0;
	void Start ()
    {
        
	}
	
	
	void Update ()
    {

        timer += Time.deltaTime;
        if (timer > 5)
        {
           // redLightOFF;
        }

	}
}
