using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGun : MonoBehaviour {

	Vector3 worldMousePos;
	public GameObject enemy;
	void Start ()
	{

	}
	void Update () 
	{
		
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit vHit;
        

		worldMousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);


        if (Physics.Raycast(ray, out vHit,100))
        {
            Debug.DrawRay(Camera.main.transform.position, (vHit.point - Camera.main.transform.position)*50,Color.black);

			if (vHit.transform.tag == "enemy")
            {
                
            }
        }

	}
}
