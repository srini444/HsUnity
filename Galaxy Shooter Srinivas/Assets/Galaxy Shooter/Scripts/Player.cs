using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private GameObject LaserPrefab;
    
    public GameObject TripleShootPrefab;

    [SerializeField]
    private float fireRate = 0.25f;
    [SerializeField]
    private float nextFire = 0.0f;

    public bool canTripleShoot = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (Time.time > nextFire)
        {
            if(canTripleShoot == true)
            {
                Instantiate(TripleShootPrefab, transform.position, Quaternion.identity);    
            }
            else
            {
                Instantiate(LaserPrefab, transform.position + new Vector3(0, 0.99f, 0), Quaternion.identity);
            }
                nextFire = Time.time + fireRate;
        }
    }


    private void Movement()
    {
        float hInputs = Input.GetAxis("Horizontal");
        float vInputs = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * hInputs * Time.deltaTime);
        transform.Translate(Vector3.up * speed * vInputs * Time.deltaTime);


        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y < -4.2f)
        {
            transform.position = new Vector3(transform.position.x, -4.2f, 0);
        }

        if (transform.position.x > 9)
        {
            transform.position = new Vector3(-9, transform.position.y, 0);
        }
        else if (transform.position.x < -9)
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }
    }

}
