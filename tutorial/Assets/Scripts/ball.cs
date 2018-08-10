using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public float moveSpeed = 10f;

	private Rigidbody rbody;
	

	// Use this for initialization
	void Start () 
	{
		rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float inputX = Input.GetAxis("Horizontal");
		float inputZ = Input.GetAxis("Vertical");

		float moveX = inputX*moveSpeed*Time.deltaTime;
		float moveZ = inputZ*moveSpeed*Time.deltaTime;

		//transform.Translate(moveX,0f,moveZ);
		rbody.AddForce(moveX,0f,moveZ);
	}

	void OnCollisionEnter(Collision col)
	{
		//print (col.collider.name);
		if(col.collider.name == "wall1")
		{
			
		}
		else if(col.collider.name == "wall2")
		{
			
		}
		else if(col.collider.name == "wall3")
		{

		}
		else if(col.collider.name == "wall4")
		{
			
		}
	}
}






