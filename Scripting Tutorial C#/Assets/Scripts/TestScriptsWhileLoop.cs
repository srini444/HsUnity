using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptsWhileLoop : MonoBehaviour {

    // Use this for initialization
    int i = 1;
    void Start ()
    {
        while (i< 6)
        {
            Debug.Log("Value of I: "+ i);
            i++;
        }

        Debug.Log("out of the While loop ");

        for (i=1; i<6 ; i++ )
        {
            Debug.Log(" The Value of I: " +i);
        }
        Debug.Log("out of the for loop");
    }


    // Update is called once per frame
    void Update() {
         
    }
}
