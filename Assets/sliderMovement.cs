using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderMovement : MonoBehaviour {

    public float sliderSpeed = 20f;
    public GameObject ball;
    public float ballSpeed = 10f;
    public static string ballState = "stay";


    // Update is called once per frame
    void Update ()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Slider Movement Right 
            transform.position = new Vector3(transform.position.x + Time.deltaTime, transform.position.y, transform.position.z);
            if (ballState == "stay")
            {
                ballState = "RightSide";
            }

        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Slider Movement Left
            transform.position = new Vector3(transform.position.x - Time.deltaTime, transform.position.y, transform.position.z);

            if (ballState == "stay")
            {
                ballState = "LeftSide";
            }
        }

        if (ballState == "LeftSide")
        {
            //Ball Movement Press Left Arrow ball move to left side
            ball.transform.Translate(new Vector3(-Time.deltaTime * ballSpeed, Time.deltaTime * ballSpeed, 0));
        }

        if(ballState == "RightSide")
        {
            //Ball Movement Press Right Arrow ball move to right side
            ball.transform.Translate(new Vector3(Time.deltaTime * ballSpeed, Time.deltaTime * ballSpeed, 0));
        }


/*
        if (ballState == "SouthWest")
        {
            ball.transform.Translate(new Vector3(-Time.deltaTime * ballSpeed, -Time.deltaTime * ballSpeed, 0));
            //(-x, -y, 0)             
        }

        if (ballState == "SouthEast")
        {
            ball.transform.Translate(new Vector3(Time.deltaTime * ballSpeed, -Time.deltaTime * ballSpeed, 0));
            //(x, -y, 0)
        }
*/
    }
}
