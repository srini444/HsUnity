using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScripts1 : MonoBehaviour {

	
	void Start ()
    {
        int a = Shoot(10);
        Debug.Log(a);
    }
	
	
	void Update ()
    {
		
	}

    int Shoot(int data)
    {
        Debug.Log("Shooting");
        Debug.Log(data);
        return (data*2);
    }
}
