using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonScript : MonoBehaviour {


    Animator catAnim;
    Rigidbody catRB;
   public GameObject cat;
    float RotateSpeed = 30f;
    float speed = 5f;

    public float increseScaleSpeed = 5f;
    Vector3 tempScale;


    void Start()
    {
      //  cat = GameObject.Find("cat");

        catAnim = cat.GetComponent<Animator>();
        catRB = cat.GetComponent<Rigidbody>();

    }


    void Update ()
    {
		
	}


    public void Jump()
    {
        catAnim.SetBool("Walk", true);
        catAnim.SetBool("Stop", false);
    }
}
