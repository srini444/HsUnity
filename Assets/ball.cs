using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public float moveSpeed = 10f;

	private Rigidbody rbody;
	private Renderer rend;
	private Light myLight;

	// Use this for initialization
	void Start () 
	{
		rbody = GetComponent<Rigidbody>();
		rend = GetComponent<Renderer>();
		myLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter(Collision col)
	{

        
        if (col.collider.name == "Leftwall")
		{
			
            if(SliderScript.ballState == "SouthWest")
            {
                SliderScript.ballState = "SouthEast";

            }

            if(SliderScript.ballState == "NorthWest")
            {
                SliderScript.ballState = "NorthEast";
            }
        }
		else if(col.collider.name == "RightWall")
		{
            if (SliderScript.ballState == "SouthEast")
            {
                SliderScript.ballState = "SouthWest";

            }

            if (SliderScript.ballState == "NorthEast")
            {
                SliderScript.ballState = "NorthWest";
            }
        }
		else if(col.collider.name == "ceiling" || col.transform.tag == "pawn")		
            {
            if (SliderScript.ballState == "NorthWest")
            {
                SliderScript.ballState = "SouthWest";

            }

            if (SliderScript.ballState == "NorthEast")
            {
                SliderScript.ballState = "SouthEast";
            }

            if(col.transform.tag == "pawn")
            {
                Destroy(col.gameObject);
            }
        }
		else if(col.collider.name == "floor")
		{
            Destroy(gameObject);

		}

        else if(col.collider.name == "Slider")
        {
            if (SliderScript.ballState == "SouthWest")
            {
                SliderScript.ballState = "NorthWest";

            }

            if (SliderScript.ballState == "SouthEast")
            {
                SliderScript.ballState = "NorthEast";
            }
        }
	}
}






