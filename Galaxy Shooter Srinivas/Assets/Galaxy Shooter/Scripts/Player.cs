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

    public bool isSpeedBoastActive = false;
    public bool canTripleShoot = false;

    public int lives = 3;
    // Use this for initialization
    [SerializeField]
    private GameObject explosionPrefab;

    public bool shieldsActive = false;

    [SerializeField]
    private GameObject shieldsGameobject;
    private GameManager gameManager;
    private SpawnManager spawnManager;

    private UIManager UIManager;
    void Start ()
    {
        transform.position = new Vector3(0, 0, 0);
        UIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        if (UIManager != null)
        {
            UIManager.UpdateLives(lives);
            
        }
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        if(spawnManager != null)
        {
            spawnManager.StartSpawnRoutine();
        }
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
        //if speed boost enable
        //move 1.5x the normal speed
        //else
        // move normal 

        if(isSpeedBoastActive == true)
        {
            transform.Translate(Vector3.right * speed * 1.5f * hInputs * Time.deltaTime);
            transform.Translate(Vector3.up * speed * 1.5f * vInputs * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * speed * hInputs * Time.deltaTime);
            transform.Translate(Vector3.up * speed * vInputs * Time.deltaTime);
        }
        


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

    public void Damage()
    {
        //subtract 1 life from the player
        if(shieldsActive == true)
        {
            shieldsActive = false;
            shieldsGameobject.SetActive(false); 
            return;
        }

        lives--;
        UIManager.UpdateLives(lives);
        if (lives < 1)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            gameManager.GameOver = true;
            UIManager.ShowTitlescreen();
            Destroy(this.gameObject);
        }

    }

    public void TripleShotPowerUpon()
    {
        canTripleShoot = true;
        StartCoroutine(TripleShotPowerDownRoutione());
    }

    public void SpeedBoastPowerUpon()
    {
        isSpeedBoastActive = true;
        StartCoroutine(SpeedBoastPowerDownRoutione());
    }

    public void EnableShields()
    {
        shieldsActive = true;
        shieldsGameobject.SetActive(true);
    }
    public IEnumerator TripleShotPowerDownRoutione()
    {
        yield return new WaitForSeconds(5.0f);
        canTripleShoot = false;
    }

    public IEnumerator SpeedBoastPowerDownRoutione()
    {
        yield return new WaitForSeconds(5.0f);
        isSpeedBoastActive = false;
    }

}
