using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPre : MonoBehaviour {

    GameObject cube1;
    GameObject cube2;
    GameObject cube3;
    bool nextPressed;
    void Start ()
    {
        cube1 = GameObject.Find("Cube1");
        cube2 = GameObject.Find("Cube2");
        cube3 = GameObject.Find("Cube3");
        
    }
	
	
	void Update ()
    {
        
    }

   public void nextButton()
    {
        Debug.Log("Next Working");
        cube1.SetActive(false);
    }
   public void preButton()
    {
        cube2.SetActive(false);
        cube1.SetActive(true);
        Debug.Log("Pre Working");
    }

}
