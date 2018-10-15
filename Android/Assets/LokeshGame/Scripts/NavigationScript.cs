using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigationScript : MonoBehaviour {

    GameObject cube;
    GameObject cube1;
   
    void Start ()
    {
        cube = GameObject.Find("cube");
        cube1 = GameObject.Find("cube1");
        cube.SetActive(true);
        cube1.SetActive(false);

    }


    void Update()
    {
        

    }

    public void nextButton()
    {
        cube.SetActive(false);
        cube1.SetActive(true);
    }

    public void previousButton()
    {
        cube.SetActive(true);
        cube1.SetActive(false);
    }
    
 
}
