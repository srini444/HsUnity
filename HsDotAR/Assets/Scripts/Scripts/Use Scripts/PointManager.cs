using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointManager : MonoBehaviour {

    public Text txtScore;
    int score;
    AudioSource dotMiss , prefectShot;
    

    // Use this for initialization
    void Start ()
    {
        dotMiss = GetComponent<AudioSource>();
        prefectShot = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Dot");
        {
            score++;
            txtScore.text = "Points : " + score;
            prefectShot.Play();        
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Board")
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().isKinematic = true;

        }
    }


}
