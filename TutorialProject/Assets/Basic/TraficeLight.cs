using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraficeLight : MonoBehaviour {

    public float red = 15f;
    public float gree = 60f;
    public float yellow = 30f;

    GameObject cube;
    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        LightOn();
        gree -= Time.deltaTime * 5;
        

    }


    void LightOn()
    {
        if (red > gree)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }

        else if(red < gree)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        else if(gree<yellow)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }


    }
}
