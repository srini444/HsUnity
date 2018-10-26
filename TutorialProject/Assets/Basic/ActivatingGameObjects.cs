using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatingGameObjects : MonoBehaviour
{
    private GameObject CubeOne;
    private GameObject CubeTwo;


	// Use this for initialization
	void Start ()
    {
        CubeOne = GameObject.Find("Cube");
        CubeTwo = GameObject.Find("Cube");

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.R))
        {
            CubeOne.SetActive(false);
            
        }

        else
        {
            CubeOne.SetActive(true);
        }
	}
}
