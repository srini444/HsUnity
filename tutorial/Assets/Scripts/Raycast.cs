using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

    public GameObject pawn;
	void Start () {

        for (int t = 0; t < 5; t++)
        {
            for (int r = 0; r < 5; r++)
            {
                GameObject temp = (GameObject)Instantiate(pawn, new Vector3(-2 + 1.5f * r, .5f , 4 - 1.5f * t),
                                                               
                    Quaternion.identity);
            }
        }

	}
	

	void Update () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit vHit;
        
        if (Physics.Raycast(ray, out vHit,100))
        {
            Debug.DrawRay(Camera.main.transform.position, (vHit.point - Camera.main.transform.position)*50,Color.black);

            if (vHit.transform.tag == "pawn")
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
