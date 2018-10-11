using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    Animator catAnim;
    Rigidbody catRB;
    float RotateSpeed = 10;
    Vector3 tempScale;
    float increseScaleSpeed = 5f;
    bool rotate = false;
    AudioSource catAudio;
    //AudioSource cAudio;


    void Start ()
    {
        catAnim = GetComponent<Animator>();
        catAudio = GetComponent<AudioSource>();
        catAnim.speed = 0f;

        catAnim.Play("Idle", -1, 0f);
        catAnim.speed = 1f;
        catAudio.Play();


    }
	
	
	void Update ()
    {
        //Close Application
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        if (rotate)
        {
            transform.Rotate(0, 2 * RotateSpeed * Time.deltaTime, 0);
        }
              
    }

    public void Jump()
    {
          catAnim.Play("Jump", -1, 0f);
          catAnim.speed = 1f;       
    }

    public void Walk()
    {
        catAnim.Play("Walk", -1, 0f);
        catAnim.speed = 1f;
        
    }

    public void Eat()
    {
        catAnim.Play("Eat", -1, 0f);
        catAnim.speed = 1f;

    }


    public void Rotate()
    {
        if (!rotate)
            rotate = true;
        else
            rotate = false;
    }

    public void Stop()
    {
        
        catAnim.Play("DoNathing", -1, 0f);
        catAudio.Play();
    }


    public void ZoomIn()
    {
        tempScale = transform.localScale;
        tempScale.x += 1f * increseScaleSpeed * Time.deltaTime;
        tempScale.y += 1f * increseScaleSpeed * Time.deltaTime;
        tempScale.z += 1f * increseScaleSpeed * Time.deltaTime;
        transform.localScale = tempScale;
    }

    public void ZoomOut()
    {
        tempScale = transform.localScale;
        tempScale.x -= 1f * increseScaleSpeed * Time.deltaTime;
        tempScale.y -= 1f * increseScaleSpeed * Time.deltaTime;
        tempScale.z -= 1f * increseScaleSpeed * Time.deltaTime;
        transform.localScale = tempScale;
    }

    public void reset()
    {
        
    }

}
