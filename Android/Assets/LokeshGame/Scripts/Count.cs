using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour {

    public Text countDisplay;
    int count =0;
    int perclick=1;

    void Update()
    {
        Increment();
        Decrement();
    }

    public void Increment()
    {
        count += perclick;
        countDisplay.text = "Count : " + count;
        
    }

    public void Decrement()
    {
        count -= perclick;
        countDisplay.text = "Count : " + count;
    }


}
