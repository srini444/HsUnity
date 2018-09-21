using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGun : MonoBehaviour {
	
	public GameObject enemy;
	void Start () 
	{

	}
	
	void Update () 
	{
		
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit vHit;
        



        if (Physics.Raycast(ray, out vHit,100))
        {
            Debug.DrawRay(Camera.main.transform.position, (vHit.point - Camera.main.transform.position)*50,Color.black);

			if (vHit.transform.tag == "enemy")
            {
                if (Input.GetMouseButtonDown(0))
                {
					if (vHit.transform.GetComponent<Renderer>().material.color != Color.red)
                    { 
						
                    vHit.transform.GetComponent<Renderer>().material.color = Color.red;

                    }
                    else
                    {
						
                    vHit.transform.GetComponent<Renderer>().material.color = Color.white;

                	}
                }
                
            }
        }





	}
}
