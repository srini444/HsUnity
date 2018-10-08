using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour {


    public GameObject enemies1;
    public GameObject enemies2;
    public GameObject enemies3;
    public GameObject enemies4;
    // Use this for initialization
    void Start ()
    {

        for (int t = 0; t < 2; t++)
        {
            for (int r = 0; r < 2; r++)
            {


                GameObject temp1 = (GameObject)Instantiate(enemies1, new Vector3(-2 + 1.6f * r, 1.05f, 1f * t), Quaternion.identity);
                GameObject temp2 = (GameObject)Instantiate(enemies2, new Vector3(1.5f + 1.6f * r, 1.05f, 1f * t), Quaternion.identity);
                /*   GameObject temp2 = (GameObject)Instantiate(enemies2, new Vector3(-4 + 1.5f * r, 1.05f, 1f - 5f * t), Quaternion.identity);
                   GameObject temp3 = (GameObject)Instantiate(enemies3, new Vector3(-4 + 1.5f * r, 1.05f, 1f - 5f * t), Quaternion.identity);
                   GameObject temp4 = (GameObject)Instantiate(enemies4, new Vector3(-4 + 1.5f * r, 1.05f, 1f - 5f * t), Quaternion.identity);*/

            }
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
