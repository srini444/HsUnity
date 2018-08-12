using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptPublicPrivate : MonoBehaviour {

    [SerializeField]
    private int a;
    //public int a;
	// Use this for initialization
	void Start () {
        Debug.Log(a);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
