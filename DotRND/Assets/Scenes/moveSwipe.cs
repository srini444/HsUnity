using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSwipe : MonoBehaviour {
    
    Rigidbody rb;

    [SerializeField]
    public float jumpForce;

    private Vector3 originalPosition;
    private Quaternion originalRotation;

    

    void Awake()
    {
        this.originalPosition = this.transform.position;
        this.originalRotation = this.transform.rotation;
    }


    void Start ()
    {
        rb = GetComponent<Rigidbody>();
      //  StartCoroutine(resetPos());        
    }
	
	
	void Update ()
    {
        
	}

    IEnumerator resetPos()
    {
        yield return new WaitForSeconds(3f);
        //Debug.Log("Swipe Dectetor");
        rb.isKinematic = false;
        rb.AddForce(Vector3.zero);
        this.transform.position = this.originalPosition;
        this.transform.rotation = this.originalRotation;
    }

    public void upSwipe()
    {
        //Debug.Log("Swipe Up");
        rb.AddForce(new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(4f, 8f), 15f) * jumpForce * Time.deltaTime, ForceMode.Impulse);
        StartCoroutine(resetPos());
    }
    public void leftSwipe()
    {
        //Debug.Log("Swipe Left");
        rb.AddForce(new Vector3(Random.Range(-3f, 0f), 5f, 15f) * jumpForce * Time.deltaTime, ForceMode.Impulse);
        StartCoroutine(resetPos());
    }
    public void rightSwipe()
    {
        //Debug.Log("Swipe Right");
        rb.AddForce(new Vector3(Random.Range(0f, 3f), 5f, 15f) * jumpForce * Time.deltaTime, ForceMode.Impulse);
        StartCoroutine(resetPos());
    }



}
