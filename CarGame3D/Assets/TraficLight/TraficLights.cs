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

   

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
  // Red Light 
        if (Input.GetKey(KeyCode.R))
        {
            //Press R Button 
            redLight.material = redLightON;
        }
        else
        {
            //Press R Button 
            redLight.material = redLightOFF;
        }



 // Yellow Light
        if (Input.GetKey(KeyCode.Y))
        {
            //Press Y Button 
            yellowLight.material = yellowLightON;
        }
        else
        {
            //Press Y Button 
            yellowLight.material = yellowLightOFF;
        }

 // Green Light
        if (Input.GetKey(KeyCode.G))
        {
            //Press Y Button 
            greenLight.material = greenLightON;
        }
        else
        {
            //Press Y Button 
            greenLight.material = greenLightOFF;
        }


    }
}
