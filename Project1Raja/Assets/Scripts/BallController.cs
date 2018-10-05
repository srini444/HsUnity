using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    [SerializeField]
    private float speed;
    Rigidbody rb;
    bool stared;
    bool gameOver;
	void Awake ()
    {
        rb = GetComponent<Rigidbody>();
	}

    void Start()
    {
        stared = false;
        gameOver = false;
    }

    void Update ()
    {
        if (!stared)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                stared = true;
            }
        }

        if (!Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            gameOver = true;
            rb.velocity = new Vector3(0,-25f,0);

            Camera.main.GetComponent<CameraFollow>().gameOver = true;
        }


        if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            SwitchDirection();
        }
	}

    void SwitchDirection()
    {
        if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
        else if (rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, speed);
          
        }
    }
}
