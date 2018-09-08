using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class TrafficLightWest : MonoBehaviour {

    
    public GameObject RedLight;
    public GameObject YellowLight;
    public GameObject GreenLight;
    
    
    public Renderer redLight;
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


		 redLight.material.color = brightRed;
		 yellowLight.material.color = dullYellow;
		 greenLight.material.color = dullGreen;
     
    }
	
	
	void Update ()
    {

        timer += Time.deltaTime;
        if (timer > 5 && timer<10 && level1 == false)
        {

			redLight.material.color = dullRed;
			greenLight.material.color = brightGreen;


            level1 = true;
        }

        
        if (timer > 10 && timer<15 && level2 == false)
        {
			greenLight.material.color = dullGreen;
			yellowLight.material.color = brightYellow;

            
            level2 = true;
           

        }

        
        if (timer >15)
        {
            
			yellowLight.material.color = dullYellow;
			redLight.material.color = brightRed;
            
            level1 = false;
            level2 = false;
            timer = 0;

        }


    }
}
