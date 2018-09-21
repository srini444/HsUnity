using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGun : MonoBehaviour {

	public GameObject enemy;
	void Start () 
	{
//
//        for (int t = 0; t < 6; t++)
//        {
//            for (int r = 0; r < 6; r++)
//            {
//                GameObject temp = (GameObject)Instantiate(pawn, new Vector3(-2 + 1.5f * r, .5f , 4 - 1.5f * t),
//                                                               
//                    Quaternion.identity);
//            }
//        }
//
	}
	

	void Update () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit vHit;
        
        if (Physics.Raycast(ray, out vHit,100))
        {
            Debug.DrawRay(Camera.main.transform.position, (vHit.point - Camera.main.transform.position)*50,Color.black);

			if (vHit.transform.tag == "enemy")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (vHit.transform.GetComponent<Renderer>().material.color != Color.black)
                    { 
                    vHit.transform.GetComponent<Renderer>().material.color = Color.black;
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
