using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScript : MonoBehaviour
{

    public static string ballState = "stay";
    float sliderSpeed = 20;
    public GameObject ball;
    float ballSpeed = 10;
    public GameObject pawn;

    void Start()
    {
        for (int t = 0; t < 3; t++)
        {
            for (int r = 0; r < 12; r++)
            {
                GameObject temp = (GameObject)Instantiate(pawn, new Vector3(-7.1f + 1.5f * r, 18.2f -1.5f*t, -0.7f),

                    Quaternion.identity);
            }
        }
    }

    void Update ()
    {

        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.position = new Vector3(transform.position.x + Time.deltaTime * sliderSpeed,
                                        transform.position.y, transform.position.z);

            if (ballState == "stay")
            {
                ballState = "NorthWest";
                //RightSide
            }
        }


       

        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            transform.position = new Vector3(transform.position.x - Time.deltaTime * sliderSpeed,
                                        transform.position.y, transform.position.z);

            if (ballState == "stay")
            {
                ballState = "NorthEast";
                //LeftSide
            }
        }

        if (ballState == "NorthWest")
        {
            ball.transform.Translate(new Vector3(-Time.deltaTime * ballSpeed, Time.deltaTime * ballSpeed, 0));
                                                 //(-x, y, 0)                           
        }

        if (ballState == "NorthEast")
        {
            ball.transform.Translate(new Vector3(Time.deltaTime * ballSpeed, Time.deltaTime * ballSpeed, 0));
                                                 //(x, y, 0)
        }

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

    }
}
