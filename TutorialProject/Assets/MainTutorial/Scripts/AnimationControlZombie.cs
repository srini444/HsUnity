using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControlZombie : MonoBehaviour {

    Animator zombieAnimation;
    Rigidbody playerRB;

    float speed = 5f;

    void Start ()
    {
        playerRB = GetComponent<Rigidbody>();
        zombieAnimation = GetComponent<Animator>();
	}
	
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            zombieAnimation.SetBool ("Walk" , true);
            zombieAnimation.SetBool("Stop", false);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            zombieAnimation.SetBool("Stop", true );
            zombieAnimation.SetBool("Walk", false);
        }
                              
	}

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRB.AddForce(new Vector3(0, 0, 5), ForceMode.VelocityChange);
            playerRB.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRB.AddForce(new Vector3(0, 0, -5), ForceMode.VelocityChange);
            playerRB.rotation = Quaternion.LookRotation(Vector3.back);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB.AddForce(new Vector3(-5, 0, 0), ForceMode.VelocityChange);
            playerRB.rotation = Quaternion.LookRotation(Vector3.left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRB.AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange);
            playerRB.rotation = Quaternion.LookRotation(Vector3.right);
        }
    }



}
