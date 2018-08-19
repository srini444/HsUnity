using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour {

    public float motorGucu;
    public WheelCollider onSol;
    public WheelCollider onSag;
    public WheelCollider arkaSol;
    public WheelCollider arkaSag;
    public float donmeGucu;
    public float frenGucu;



    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        float v = Input.GetAxis("Vertical") * motorGucu;
        float h = Input.GetAxis("Horizontal") * donmeGucu;

        arkaSol.motorTorque = v;
        arkaSag.motorTorque = v;

        onSol.steerAngle = h;
        onSag.steerAngle = h;

        if (Input.GetKey(KeyCode.Space))
        {
            arkaSol.brakeTorque = frenGucu;
            arkaSag.brakeTorque = frenGucu;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            arkaSol.brakeTorque = 0;
            arkaSag.brakeTorque = 0;

        }

    }
}
