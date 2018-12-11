using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointManager : MonoBehaviour {

    public Text txtScore;
    int score;
    Rigidbody rb;

    // Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
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
            rb.isKinematic = true;
        }
    }


   
}
