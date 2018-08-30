using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour {

    public float speed = 1f;
    // Use this for initialization
    void Start ()
    {
        StartCoroutine("cotest");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + Time.deltaTime * speed, transform.position.y, transform.position.z);
        }

       

    }

    IEnumerator cotest()
    {
     
       
        Debug.Log("Stated");
        yield return new WaitForSeconds(60f);
       
        Debug.Log("End");
    }

}
