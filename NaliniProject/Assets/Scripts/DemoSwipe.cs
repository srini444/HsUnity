using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoSwipe : MonoBehaviour {

    public GameObject dotPrefab;
    public Rigidbody rb;
    public float dotForce;
    GameObject dotInstate;
    Vector3 mouseStart;
    Vector3 mouseEnd;
    float minDragDis = 50f;
    float zDepth = 25f;
    // Use this for initialization
    void Start ()
    {
        CreateDot();

    }
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetMouseButtonDown(0))
        {
            mouseStart = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            mouseEnd = Input.mousePosition;

            if (Vector3.Distance(mouseEnd, mouseStart) > minDragDis)
            {
                // Throw ball
                Vector3 hitpos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDepth);
                hitpos = Camera.main.ScreenToWorldPoint(hitpos);

                dotInstate.transform.LookAt(hitpos);
                dotInstate.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * dotForce, ForceMode.Impulse);

            }
        }

	}

    void CreateDot()
    {
        dotInstate = Instantiate(dotPrefab, dotPrefab.transform.position, dotPrefab.transform.rotation) as GameObject;
    }
}
