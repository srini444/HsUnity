using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    public GameObject dotPrefab;
    GameObject dotInsstance;
    public Transform target;
    public float dotForce = 25f;
    Vector3 mouseStart;
    Vector3 mouseEnd;
    float minSwipeDistance = 15f;
    float zDepth;

    void Start ()
    {
        CreateDot();
    }
	
    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseStart = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            mouseEnd = Input.mousePosition;
            Vector3 targetDir = target.position - transform.position;
            Vector3 forward = transform.forward;
            float angle = Vector3.SignedAngle(targetDir, forward, Vector3.up);

            if (angle < -10.0F)
            {
                dotInsstance.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-10.0f, 10.0f), Random.Range(50.0f, 10.0f)) * dotForce * Time.deltaTime, ForceMode.Impulse);
                print("turn left");
                Invoke("CreateDot", 3f);
            }
               
            else if (angle > 10.0F)
            {
                dotInsstance.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-10.0f, 10.0f), Random.Range(50.0f, 10.0f)) * dotForce * Time.deltaTime, ForceMode.Impulse);
                print("turn right");
                Invoke("CreateDot", 3f);
            }
            
            else
            {
                dotInsstance.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-10.0f, 10.0f), Random.Range(50.0f, 10.0f)) * dotForce * Time.deltaTime, ForceMode.Impulse);
                print("forward");
                Invoke("CreateDot", 3f);
            }
     
        }

    }

    void CreateDot()
    {
        dotInsstance = Instantiate(dotPrefab, dotPrefab.transform.position, dotPrefab.transform.rotation) as GameObject;
    }

}
