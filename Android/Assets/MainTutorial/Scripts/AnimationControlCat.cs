using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AnimationControlCat : MonoBehaviour {

    Animator catAnim;
    Rigidbody catRB;

    float RotateSpeed = 30f;


    public float increseScaleSpeed = 5f;
    Vector3 tempScale;


    void Start ()
    {
        catAnim = GetComponent<Animator>();
        catRB = GetComponent<Rigidbody>();
        
    }
	
	
	void Update ()
    {

// Move Cat
        
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            catAnim.SetBool("Walk", true);
            catAnim.SetBool("Stop", false);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            catAnim.SetBool("Stop", true);
            catAnim.SetBool("Walk", false);
        }
// Eat Cat
        if (Input.GetKeyDown(KeyCode.E))
        {
            catAnim.SetBool("Eat", true);
            catAnim.SetBool("Stop", false);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            catAnim.SetBool("Eat", false);
            catAnim.SetBool("Stop", true);
        }

//Jump Cat
        if (Input.GetKeyDown(KeyCode.J))
        {
            catAnim.SetBool("Jump", true);
            catAnim.SetBool("Stop", false);
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            catAnim.SetBool("Jump", false);
            catAnim.SetBool("Stop", true);
        }

// Rotate Cat       
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(0, 1 * RotateSpeed * Time.deltaTime, 0);
        }

// ZoomIn Cat 
        
        if (Input.GetKey(KeyCode.U))
        {
            tempScale = transform.localScale;
            tempScale.x += 1f * increseScaleSpeed * Time.deltaTime;
            tempScale.y += 1f * increseScaleSpeed * Time.deltaTime;
            tempScale.z += 1f * increseScaleSpeed * Time.deltaTime;
            transform.localScale = tempScale;
        }

// ZoomOut Cat 
        if (Input.GetKey(KeyCode.D))
        {
            tempScale = transform.localScale;
            tempScale.x -= 1f * increseScaleSpeed * Time.deltaTime;
            tempScale.y -= 1f * increseScaleSpeed * Time.deltaTime;
            tempScale.z -= 1f * increseScaleSpeed * Time.deltaTime;
            transform.localScale = tempScale;
        }


    }

//Move Cat
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            catRB.AddForce(new Vector3(0, 0, 5), ForceMode.VelocityChange); 
            catRB.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            catRB.AddForce(new Vector3(0, 0, -5), ForceMode.VelocityChange);
            catRB.rotation = Quaternion.LookRotation(Vector3.back);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            catRB.AddForce(new Vector3(-5, 0, 0), ForceMode.VelocityChange);
            catRB.rotation = Quaternion.LookRotation(Vector3.left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            catRB.AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange);
            catRB.rotation = Quaternion.LookRotation(Vector3.right);
        }
    }

   
   
}
