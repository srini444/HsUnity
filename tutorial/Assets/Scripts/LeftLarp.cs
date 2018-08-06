using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLarp : MonoBehaviour
{
    public float smooth = 2;
    private Vector3 newPosition;
	
	void Awake ()
    {
        newPosition = transform.position;
	}
	
	
	void Update ()
    {
        PositionChanging();
	}

    void PositionChanging()
    {
        Vector3 positionA = new Vector3(-5, 3, 0);
        Vector3 positionB = new Vector3(5, 3, 0);

        if (Input.GetKeyDown(KeyCode.Q))
            newPosition = positionA;
        if (Input.GetKeyDown(KeyCode.E))
            newPosition = positionB;

        transform.position = Vector3.Lerp(transform.position, newPosition,Time.deltaTime * smooth);
    }

}
