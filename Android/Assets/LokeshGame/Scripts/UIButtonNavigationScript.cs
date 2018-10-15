using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonNavigationScript : MonoBehaviour {

    GameObject cube;
    GameObject cube1;
    

    void Start ()
    {
        cube = GameObject.Find("cube");
        cube1 = GameObject.Find("cube1");
                
	}
	
	

	void Update ()
    {
        cube.SetActive(false);
        cube1.SetActive(false);
    }

 }
