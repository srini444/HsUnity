using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    [SerializeField]
    private GameObject enemyExplosionPrefab;
    private float speed = 5.0f;
    private UIManager ui;
    [SerializeField]
    private AudioClip _clip;
    
	// Use this for initialization
	void Start ()
    {        
        ui = GameObject.Find("Canvas").GetComponent<UIManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //move down
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        // when off the screen on the bottom
        if(transform.position.y < -7)
        {
            transform.position = new Vector3(Random.Range(-7,7), 7, 0);
        }
        // respawn back on top with a new x position b/w the bounds of the screen

	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "laser")
        {
            if(other.transform.parent != null)
            {
                Destroy(other.transform.parent.gameObject);
            }
            Destroy(other.gameObject);
            Instantiate(enemyExplosionPrefab, transform.position, Quaternion.identity);
            ui.UpdateScore();
            AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position,1f);
            Destroy(this.gameObject);
        }
        else if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if(player != null)
            {
                player.Damage();
            }
            Instantiate(enemyExplosionPrefab, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position,1f);
            Destroy(this.gameObject);
        }
    }
}
