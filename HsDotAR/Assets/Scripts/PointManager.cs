using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointManager : MonoBehaviour {

    public Text txtScore;
    int score;
    
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Dot") ;
        {
            score++;
            txtScore.text = "Points : " + score;
        }
    }


   
}
