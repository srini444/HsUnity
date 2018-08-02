using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carScript : MonoBehaviour {

	public float speed;
	public GameObject food;



	void Start () {
		speed = 5;

		food.transform.position = new Vector3 (Random.Range (-9, 9), 0.5f, Random.Range (-8, 8));
	}
	

	void Update () {


		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + Time.deltaTime* speed);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position = new Vector3 (transform.position.x - Time.deltaTime* speed, transform.position.y, transform.position.z);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position = new Vector3 (transform.position.x + Time.deltaTime* speed, transform.position.y, transform.position.z);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - Time.deltaTime* speed);
		}




		
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.transform.tag == "food") {
			food.transform.position = new Vector3 (Random.Range (-9, 9), 0.5f, Random.Range (-8, 8));
			Debug.Log ("Collision etected");
		}
		Debug.Log ("Collision etected");

	}

	//void OnCollisionEnter(Collision other)
	//{
		
	//}
}
