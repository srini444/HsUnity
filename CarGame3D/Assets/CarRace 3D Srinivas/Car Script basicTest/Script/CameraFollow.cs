﻿using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offsetRot;
    public Vector3 offset;

    void Start()
    {
        //offset = target.transform.position - transform.position;
    }
    void Update()
    {

    /*    Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;*/
        transform.LookAt(target);

    }


}
