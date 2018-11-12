using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour {

    public Text countDisplay;
    int count =1;
    int perclick=1;
    GameObject cube1;
    GameObject cube2;
    void Start()
    {
        cube1 = GameObject.Find("cube1");
        cube2 = GameObject.Find("cube2");
    }

    void Update()
    {
        //Increment();
        //Decrement();

    }

    public void Increment()
    {
            count += perclick;
            countDisplay.text = "Count : " + count;
            cube1.SetActive(true);
            cube2.SetActive(false);
    }

    public void Decrement()
    {
            count -= perclick;
            countDisplay.text = "Count : " + count;
            cube2.SetActive(true);
            cube1.SetActive(false);

    }


}
