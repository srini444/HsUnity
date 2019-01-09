using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartInsstance : MonoBehaviour {

   // SwipeDartScript Dart = new SwipeDartScript();
    GameObject DartInsstance1;
    public GameObject DartPrefab;

    // Use this for initialization
    void Start ()
    {
        CreateDot();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void CreateDot()
    {
        DartInsstance1 = Instantiate(DartPrefab, DartPrefab.transform.position, Quaternion.identity) as GameObject;
    }
}
