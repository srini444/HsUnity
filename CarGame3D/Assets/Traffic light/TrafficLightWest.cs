using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightWest : MonoBehaviour {


    public GameObject RedLightWest;
    public GameObject YellowLightWest;
    public GameObject GreenLightWest;
    
    
    public Renderer redLightWest;
    public Renderer yellowLightWest;
    public Renderer greenLightWest;
    

    public Color brightYellowWest;
    public Color dullYellowWest;

    public Color brightRedWest;
    public Color dullRedWest;

    public Color brightGreenWest;
    public Color dullGreenWest;

    bool level1, level2, level3;
    float timer = 0;
	void Start ()
    {
        YellowLightWest = transform.Find("Yellow").gameObject;
        RedLightWest = transform.Find("Red").gameObject;
        GreenLightWest = transform.Find("Green").gameObject;

        yellowLightWest = YellowLightWest.GetComponent<Renderer>();
        redLightWest = RedLightWest.GetComponent<Renderer>();
        greenLightWest = GreenLightWest.GetComponent<Renderer>();

        yellowLightWest.material.color = dullYellowWest;
        redLightWest.material.color = brightRedWest;
        greenLightWest.material.color = dullGreenWest;
    }
	
	
	void Update ()
    {

        timer += Time.deltaTime;
        if (timer > 5 && timer<10 && level1 == false)
        {
            //yellowLightWest.material.color = brightYellowWest;
            redLightWest.material.color = brightRedWest;
            Debug.Log("Red Light on West");
            
            redLightWest.material.color = dullRedWest;
            level1 = true;
        }

        
        if (timer > 10 && timer<15 && level2 == false)
        {
            yellowLightWest.material.color = dullYellowWest;
            greenLightWest.material.color = brightGreenWest;
            Debug.Log("Green Light on West");
            level2 = true;
           

        }

        
        if (timer >15)
        {
            greenLightWest.material.color = dullGreenWest;
            redLightWest.material.color = brightRedWest;
            Debug.Log("Red Light on West");

            level1 = false;
            level2 = false;
            timer = 0;

        }


    }
}
