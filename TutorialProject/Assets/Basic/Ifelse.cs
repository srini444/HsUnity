using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ifelse : MonoBehaviour {

    public float coffeeTemp = 85.0f;
    public float hotLimtTemp = 75.0f;
    public float coldLimtTemp=45.0f;
	
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
             TempTest();
        coffeeTemp -= Time.deltaTime * 5;
	}

    void TempTest()
    {
        if (coffeeTemp > hotLimtTemp)
        {
            Debug.Log("Coffee is too hot");
        }

        else if (coffeeTemp<coldLimtTemp)
        {
            Debug.Log("Coffee is too cold");
        }
        else
        {
            Debug.Log("Coffee is Good");
        }
    }

}
