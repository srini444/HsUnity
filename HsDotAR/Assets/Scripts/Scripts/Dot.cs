using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    public static Dot manager;



    public GameObject dotPrefab;
    GameObject dotInsstance;
    public Transform target;
    public float dotForce = 25f;
    Vector3 mouseStart;
    Vector3 mouseEnd;
    float minSwipeDistance = 15f;
    float zDepth;

   
    AudioSource arrowSound;

    private void Awake()
    {
        if(manager == null)
        {
            manager = this;
        }
    }

    void Start ()
    {
        CreateDot();
        arrowSound = GetComponent<AudioSource>();
        
    }
	
    void Update ()
    {
        if (Input.GetMouseButtonUp(0))
        {
            dotInsstance.GetComponent<DartArrow>().DestroyArrow();
            mouseEnd = Input.mousePosition;
            Vector3 targetDir = target.position - transform.position;
            Vector3 forward = transform.forward;
            float angle = Vector3.SignedAngle(targetDir, forward, Vector3.up);

            if (angle < -10.0F)
            {
                arrowSound.Play();
                
                dotInsstance.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(Random.Range(-3.5f, 3.50f), Random.Range(0.0f, 5.0f), Random.Range(10f, 20.0f)) * dotForce * Time.deltaTime, ForceMode.Impulse);
                print("turn left");
                //Invoke("CreateDot", 3f);
            }
               
            else if (angle > 10.0F)
            {
                arrowSound.Play();
                
                dotInsstance.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(Random.Range(-3.5f, 3.5f), Random.Range(0.0f, 5.0f), Random.Range(10f, 20.0f)) * dotForce * Time.deltaTime, ForceMode.Impulse);
                print("turn right");
                //Invoke("CreateDot", 3f);
            }
            
            else
            {
                arrowSound.Play();
               
                dotInsstance.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(Random.Range(-3.5f, 3.5f), Random.Range(0.0f, 5.0f), Random.Range(10f, 20.0f)) * dotForce * Time.deltaTime, ForceMode.Impulse);
                print("forward");
                //Invoke("CreateDot", 3f);
            }
     
        }
    

    }

   public void CreateDot()
    {
        dotInsstance = Instantiate(dotPrefab, dotPrefab.transform.position, dotPrefab.transform.rotation) as GameObject;
       
    }

}
