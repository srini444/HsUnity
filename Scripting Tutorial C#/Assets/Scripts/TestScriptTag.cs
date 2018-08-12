using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptTag : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        /*
        if (this.gameObject.tag == "SrinivasTag")
        {
            Debug.Log("its Qued Srinivas");
        }
       */
	}

    /*
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");

        if(col.gameObject.tag == "SrinivasTag")
        {
            Destroy(col.gameObject);
        }

        */

    void OnTriggerEnter2D(Collider2D col)
        {

            if(col.gameObject.tag == "Siri")
            {
                Destroy(col.gameObject);
            }
        }    


    
    // Update is called once per frame
    void Update ()
    {
		
	}
}
