using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour {


    public Text texScore;
    int score;

    // Use this for initialization
    void Start () {

	}

	// Update is called once per frame
	void Update () 
	{

	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "enemy")
		{
			Destroy(collision.gameObject);

			gameObject.SetActive(false);

            score++;
            texScore.text = "Score : " + score;

		}
	}


}