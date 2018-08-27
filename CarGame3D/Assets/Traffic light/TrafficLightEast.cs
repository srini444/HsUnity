using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightEast : MonoBehaviour {


    public GameObject RedLightEast;
    public GameObject YellowLightEast;
    public GameObject GreenLightEast;
    
    
    public Renderer redLightEast;
    public Renderer yellowLightEast;
    public Renderer greenLightEast;
    

    public Color brightYellowEast;
    public Color dullYellowEast;

    public Color brightRedEast;
    public Color dullRedEast;

    public Color brightGreenEast;
    public Color dullGreenEast;

    bool level1, level2, level3;
    float timer = 0;
	void Start ()
    {
        YellowLightEast = transform.Find("Yellow").gameObject;
        RedLightEast = transform.Find("Red").gameObject;
        GreenLightEast = transform.Find("Green").gameObject;

        yellowLightEast = YellowLightEast.GetComponent<Renderer>();
        redLightEast = RedLightEast.GetComponent<Renderer>();
        greenLightEast = GreenLightEast.GetComponent<Renderer>();

        yellowLightEast.material.color = dullYellowEast;
        redLightEast.material.color = brightRedEast;
        greenLightEast.material.color = dullGreenEast;
    }
	
	
	void Update ()
    {

        timer += Time.deltaTime;
        if (timer > 5 && timer<10 && level1 == false)
        {
            yellowLightEast.material.color = brightYellowEast;
            Debug.Log("Yellow Light on East");
            redLightEast.material.color = dullRedEast;
            level1 = true;
        }

        
        if (timer > 10 && timer<15 && level2 == false)
        {
            yellowLightEast.material.color = dullYellowEast;
            greenLightEast.material.color = brightGreenEast;
            Debug.Log("Green Light on East-------------------------------------");
            level2 = true;
           

        }

        
        if (timer >15)
        {
            greenLightEast.material.color = dullGreenEast;
            redLightEast.material.color = brightRedEast;
            Debug.Log("Red Light on East");

            level1 = false;
            level2 = false;
            timer = 0;

        }


    }
}
