using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeftLarpColour : MonoBehaviour
{
    public float smooth = 2f;
    private Color newColour;
    

    void Awake ()
    {
        newColour = transform.GetComponent<Light>().color;


    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
