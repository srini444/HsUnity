using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightOneByOne : MonoBehaviour {

    public GameObject YellowLight;
    public GameObject RedLight;
    public GameObject GreenLight;
    // Red Light
    public Renderer redLight;

   

    // Yellow Light
    public Renderer yellowLight;

   

    public Renderer greenLight;

    public Color brightYellow;
    public Color dullYellow;

    public Color brightRed;
    public Color dullRed;

    public Color brightGreen;
    public Color dullGreen;

    bool level1, level2, level3;
    float timer = 0;
	void Start ()
    {
        YellowLight = transform.Find("Yellow").gameObject;
        RedLight = transform.Find("Red").gameObject;
        GreenLight = transform.Find("Green").gameObject;

        yellowLight = YellowLight.GetComponent<Renderer>();
        redLight = RedLight.GetComponent<Renderer>();
        greenLight = GreenLight.GetComponent<Renderer>();

        yellowLight.material.color = dullYellow;
        redLight.material.color = brightRed;
        greenLight.material.color = dullGreen;
    }
	
	
	void Update ()
    {

        timer += Time.deltaTime;
        if (timer > 5 && timer<10 && level1 == false)
        {
            yellowLight.material.color = brightYellow;
            redLight.material.color = dullRed;
            level1 = false;
        }

        
        if (timer > 10 && timer<15 && level2 == false)
        {
            yellowLight.material.color = dullYellow;
            greenLight.material.color = brightGreen;
            level2 = true;
           

        }

        
        if (timer >15)
        {
            greenLight.material.color = dullGreen;
            redLight.material.color = brightRed;
            
            level1 = false;
            level2 = false;
            timer = 0;

        }


    }
}
