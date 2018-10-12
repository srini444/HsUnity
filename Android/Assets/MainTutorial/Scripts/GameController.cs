using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField]
    GameObject ballPrefab;

     
    [SerializeField]
    float ballForce;

    GameObject ballInstances;
    Vector3 mouseStart;
    Vector3 mouseEnd;

    float minDragDistance = 15f;
    float zDepth = 25f;

   

    void Start ()
    {
        
        CreateBall();

        ballInstances.transform.Rotate(new Vector3(Random.Range(-18f, -25f), Random.Range(2f,10f), 0));
        
    }
	
	
	void Update ()
    {

        if (Input.GetMouseButtonDown(0))
        {
            mouseStart = Input.mousePosition;
        }

        if(Input.GetMouseButtonUp(0))
        {
            mouseEnd = Input.mousePosition;

            if(Vector3.Distance(mouseEnd,mouseStart) > minDragDistance)
            {
                //throw ball

                Vector3 hitPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDepth);

                hitPos =  Camera.main.ScreenToWorldPoint(hitPos);
                ballInstances.transform.LookAt(hitPos);
                ballInstances.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * ballForce, ForceMode.Impulse);

            }
        }

	}

    void CreateBall()
    {
        ballInstances = Instantiate(ballPrefab, ballPrefab.transform.position, Quaternion.identity) as GameObject;
    }

}
