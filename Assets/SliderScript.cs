using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScript : MonoBehaviour
{

    public static string ballState = "stay";
    float sliderSpeed = 10;
    public GameObject ball;
    float ballSpeed = 5;
	void Update ()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x + Time.deltaTime * sliderSpeed,
                                        transform.position.y, transform.position.z);

            if (ballState == "stay")
            {
                ballState = "NorthWest";
            }
        }


        if (ballState == "NorthWest")
        {
            ball.transform.Translate(new Vector3(-Time.deltaTime * ballSpeed, Time.deltaTime * ballSpeed, 0));
        }

         if (ballState == "NorthEast")
        {
            ball.transform.Translate(new Vector3(Time.deltaTime * ballSpeed, Time.deltaTime * ballSpeed, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x - Time.deltaTime * sliderSpeed,
                                        transform.position.y, transform.position.z);

            if (ballState == "stay")
            {
                ballState = "NorthEast";
            }
        }

    }
    void OnCollisionEnter(Collision col)
    {

        

        if (col.collider.name == "ceiling")
        {
            Debug.Log("Collider With ceiling");
        }
        else if (col.collider.name == "wall1")
        {

        }
        else if (col.collider.name == "wall3")
        {
            Debug.Log("Collider With Left"); 
        }
        else if (col.collider.name == "floor")
        {

        }

        else if (col.collider.name == "wall4")
        {

        }
    }
}
