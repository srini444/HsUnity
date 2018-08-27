using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightNorth : MonoBehaviour {


    public GameObject RedLightNorth;
    public GameObject YellowLightNorth;
    public GameObject GreenLightNorth;
    
    
    public Renderer redLightNorth;
    public Renderer yellowLightNorth;
    public Renderer greenLightNorth;
    

    public Color brightYellowNorth;
    public Color dullYellowNorth;

    public Color brightRedNorth;
    public Color dullRedNorth;

    public Color brightGreenNorth;
    public Color dullGreenNorth;

    bool level1, level2, level3;
    float timer = 0;
	void Start ()
    {
        YellowLightNorth = transform.Find("Yellow").gameObject;
        RedLightNorth = transform.Find("Red").gameObject;
        GreenLightNorth = transform.Find("Green").gameObject;

        yellowLightNorth = YellowLightNorth.GetComponent<Renderer>();
        redLightNorth = RedLightNorth.GetComponent<Renderer>();
        greenLightNorth = GreenLightNorth.GetComponent<Renderer>();

        yellowLightNorth.material.color = dullYellowNorth;
        redLightNorth.material.color = brightRedNorth;
        greenLightNorth.material.color = dullGreenNorth;
    }
	
	
	void Update ()
    {

        timer += Time.deltaTime;
        if (timer > 5 && timer<10 && level1 == false)
        {
            yellowLightNorth.material.color = brightYellowNorth;
            Debug.Log("Yellow Light on North");
            redLightNorth.material.color = dullRedNorth;
            level1 = true;
        }

        
        if (timer > 10 && timer<15 && level2 == false)
        {
            yellowLightNorth.material.color = dullYellowNorth;
            greenLightNorth.material.color = brightGreenNorth;
            Debug.Log("Green Light on North-------------------------------------");
            level2 = true;
           

        }

        
        if (timer >15)
        {
            greenLightNorth.material.color = dullGreenNorth;
            redLightNorth.material.color = brightRedNorth;
            Debug.Log("Red Light on North");

            level1 = false;
            level2 = false;
            timer = 0;

        }


    }
}
