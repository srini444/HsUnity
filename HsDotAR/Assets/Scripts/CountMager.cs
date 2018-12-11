using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountMager : MonoBehaviour {

    public int Points = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 100, 200), " Points : " + Points);
    }
}
