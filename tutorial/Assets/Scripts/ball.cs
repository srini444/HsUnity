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
		float inputY = Input.GetAxis("Vertical");

		float moveX = inputX*moveSpeed*Time.deltaTime;
		float moveY = inputY*moveSpeed*Time.deltaTime;

		//transform.Translate(moveX,0f,moveZ);
		rbody.AddForce(moveX,moveY,0f);
	}

    public void AdjustSpeed (float NewmoveSpeed)
    {
        moveSpeed = NewmoveSpeed;
    }

	void OnCollisionEnter(Collision col)
	{
		
		if(col.collider.name == "ForntWall")
		{
			
		}
		else if(col.collider.name == "Ground")
		{
			
		}
		else if(col.collider.name == "RightWall")
		{

		}
		else if(col.collider.name == "LeftWall")
		{
			
		}

        else if (col.collider.name == "Top")
        {

        }
    }
}






