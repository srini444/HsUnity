using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject palyer;
    public bool GameOver = true;

    private UIManager UIManager;
    // Use this for initialization
	void Start ()
    {
        UIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(GameOver == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(palyer, Vector3.zero, Quaternion.identity);
                GameOver = false;
                UIManager.HideTitlescreen();
            }
        }
	}
}
