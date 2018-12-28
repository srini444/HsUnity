using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointManager : MonoBehaviour {

    public Text txtScore;
    int score;
    AudioSource dotMiss , prefectShot;
    

    // Use this for initialization
    void Start ()
    {
        dotMiss = GetComponent<AudioSource>();
        prefectShot = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with: " + other.name);
        if (other.name == "Board") ;
        {
             score++;
             txtScore.text = "Points : " + score;
             prefectShot.Play(); 
            //Destroy(gameObject);
        }
        
    }

/*
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collided with: " + other.name);
    }

*/
       private void OnCollisionEnter(Collision collision)
        {
            //if( collision.gameObject.name == "10score")
            // score +=10;
            //elseif( collision.gameObject.name == "9score")
            // score +=9;
            if (collision.gameObject.name == "Board")
            {
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                GetComponent<Rigidbody>().isKinematic = true;

            }
        }
    
 /*   
      private void OnCollisionEnter2D(Collision2D collision)
      {
          if (collision.gameObject.name == "1")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

          else if (collision.gameObject.name == "2")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "3")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "4")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "5")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "6")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "7")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

        else if(collision.gameObject.name == "8")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "9")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "10")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "11")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "12")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "13")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "14")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "15")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "16")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "17")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "18")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

          else if (collision.gameObject.name == "19")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

         else if (collision.gameObject.name == "20")
          {
              GetComponent<Rigidbody>().velocity = Vector3.zero;
              GetComponent<Rigidbody>().isKinematic = true;

          }

      }
      */
}
