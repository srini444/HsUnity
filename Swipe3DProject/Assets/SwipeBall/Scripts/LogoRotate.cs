using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoRotate : MonoBehaviour {

    [SerializeField]
    float rSpeed = 1f;
	
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.Rotate(new Vector3(0,0,-45*rSpeed*Time.deltaTime));
    }
}
