using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.collider.name == "LeftWall")
        {

    /*       if(sliderMovement.ballState == "RightSide")
            {
                sliderMovement.ballState = "LeftSide";
            }

    */   
    }
    }
}
