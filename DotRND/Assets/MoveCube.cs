using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCube : MonoBehaviour {

    [SerializeField]
    private float speed = 10f;
    public Text countText;
    private int count;

	// Use this for initialization
	void Start ()
    {
        count = 0;
        SetCount();

    }
	
	// Update is called once per frame
	void Update ()
    {
        moveCube();
    }

    void moveCube()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime*speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime *speed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime*speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime*speed);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCount();
        }

        if (other.gameObject.CompareTag("Coin1"))
        {
            other.gameObject.SetActive(false);
            count = count + 3;
            SetCount();
        }
    }

    void SetCount()
    {
        countText.text = "Count: " + count.ToString();
    }
}
