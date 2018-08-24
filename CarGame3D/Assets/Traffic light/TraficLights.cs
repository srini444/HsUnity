using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraficLights : MonoBehaviour {
    // Red Light
    public Renderer redLight;

    public Material redLightON;
    public Material redLightOFF;

    // Yellow Light
    public Renderer yellowLight;

    public Material yellowLightON;
    public Material yellowLightOFF;

    // Green Light
    public Renderer greenLight;

    public Material greenLightON;
    public Material greenLightOFF;

    public Light sportLightRed;
    public Light sportLightGreen;
    public Light sportLightYellow;

   
	
	void Update ()
    {
  // Red Light 
        if (Input.GetKey(KeyCode.R))
        {
            //Press R Button 
            redLight.material = redLightON;
            sportLightRed.intensity = 20f;
        }
        else
        {
            //Press R Button 
            redLight.material = redLightOFF;
            sportLightRed.intensity = 0f;
        }



 // Yellow Light
        if (Input.GetKey(KeyCode.Y))
        {
            //Press Y Button 
            yellowLight.material = yellowLightON;
            sportLightYellow.intensity = 20f;
        }
        else
        {
            //Press Y Button 
            yellowLight.material = yellowLightOFF;
            sportLightYellow.intensity = 0f;
        }

 // Green Light
        if (Input.GetKey(KeyCode.G))
        {
            //Press Y Button 
            greenLight.material = greenLightON;
            sportLightGreen.intensity = 20f;
        }
        else
        {
            //Press Y Button 
            greenLight.material = greenLightOFF;
            sportLightGreen.intensity = 0f;
        }


    }
}

