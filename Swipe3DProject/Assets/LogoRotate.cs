using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoRotate : MonoBehaviour {

    [SerializeField]
    float rSpeed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.Rotate(new Vector3(0,0,-45*rSpeed*Time.deltaTime));

    }
}
