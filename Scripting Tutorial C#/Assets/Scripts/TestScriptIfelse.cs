using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptIfelse : MonoBehaviour {

    int life = 5;
	// Use this for initialization
	void Start ()
    {
        life = 11;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (life < 1)
        {
            Debug.Log("Game Over");
        }
        else if(life > 5)
        {
            Debug.Log("Super Power");
        }
        else if (life > 10)
        {
            Debug.Log("Ultra Power");
        }

        else
        {
            Debug.Log("Playing");
        }
	}
}
