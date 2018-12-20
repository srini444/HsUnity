using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    [SerializeField]
    private float speed = 3.0f;
    [SerializeField]
    private int powerID; // 0 == triple shot 1 speed boot 2 shields
                         // Use this for initialization

    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collied with " + other.name);
        
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if(player != null)
            {
                // enable triple shot
                // if powerId ==0 
                if (powerID == 0)
                {
                    player.TripleShotPowerUpon();
                }
                else if(powerID == 1)
                {
                    //enable speed
                    player.SpeedBoastPowerUpon();
                }
                else if(powerID == 2)
                {
                    //enable shiedls
                }

                

            }

            Destroy(this.gameObject);
        }

    }
}
