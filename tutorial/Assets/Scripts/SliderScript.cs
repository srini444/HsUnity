﻿using System.Collections;
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
        // Ball Move to Left Side
        if (ballState == "NorthWest")
        {
            ball.transform.Translate(new Vector3(-Time.deltaTime * ballSpeed, Time.deltaTime * ballSpeed, 0));
        }

      
        
        // Press Right Arrow Ball and Slider Move Right side 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x - Time.deltaTime * sliderSpeed,
                                       transform.position.y, transform.position.z);
            if (ballState == "stay")
            {
                ballState = "NorthEast";
            }
        }

        // Ball Move to Right Side
        if (ballState == "NorthEast")
        {
            ball.transform.Translate(new Vector3(Time.deltaTime * ballSpeed, Time.deltaTime * ballSpeed, 0));
        }


    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "RightWall")
        {
           

        } 


        
    }


}
