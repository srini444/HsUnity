using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour {

    public Camera[] cams;
	
    public void camOne()
    {
        cams[0].enabled = true;
        cams[1].enabled = false;
    }

    public void camMain()
    {
        cams[0].enabled = false;
        cams[1].enabled = true;
    }


    void Update ()
    {
		
	}
}
