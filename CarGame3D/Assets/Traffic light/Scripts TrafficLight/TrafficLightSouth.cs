using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class TrafficLightSouth : MonoBehaviour {


    public GameObject RedLightSouth;
    public GameObject YellowLightSouth;
    public GameObject GreenLightSouth;
    
    
    public Renderer redLightSouth;
    public Renderer yellowLightSouth;
    public Renderer greenLightSouth;
    

    public Color brightYellowSouth;
    public Color dullYellowSouth;

    public Color brightRedSouth;
    public Color dullRedSouth;

    public Color brightGreenSouth;
    public Color dullGreenSouth;

    bool level1, level2, level3;
    float timer = 0;
	void Start ()
    {
        YellowLightSouth = transform.Find("Yellow").gameObject;
        RedLightSouth = transform.Find("Red").gameObject;
        GreenLightSouth = transform.Find("Green").gameObject;

        yellowLightSouth = YellowLightSouth.GetComponent<Renderer>();
        redLightSouth = RedLightSouth.GetComponent<Renderer>();
        greenLightSouth = GreenLightSouth.GetComponent<Renderer>();

        yellowLightSouth.material.color = dullYellowSouth;
        redLightSouth.material.color = brightRedSouth;
        greenLightSouth.material.color = dullGreenSouth;
    }
	
	
	void Update ()
    {
       
        timer += Time.deltaTime;
        if (timer > 5 && timer<10 && level1 == false)
        {
            greenLightSouth.material.color = brightGreenSouth;
            Debug.Log("Green Light on South");
            
            greenLightSouth.material.color = dullGreenSouth;
            level1 = true;
        }

        
        if (timer > 10 && timer<15 && level2 == false)
        {

            redLightSouth.material.color = dullRedSouth;
            yellowLightSouth.material.color = brightYellowSouth;
            Debug.Log("Yellow Light on South");
            level2 = true;
           

        }

        
        if (timer >15)
        {
            yellowLightSouth.material.color = dullYellowSouth;
            redLightSouth.material.color = brightRedSouth;
            Debug.Log("Red Light on South");

            level1 = false;
            level2 = false;
            timer = 0;

        }

    
       

    }
}
