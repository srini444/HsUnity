using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalulateScore : MonoBehaviour {

    public Text countText;
    private int count;

    void Start ()
    {
        count = 0;
        SetCount();
    }
	
	
	void Update ()
    {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            //other.gameObject.SetActive(false);
            count = count + 1;
            SetCount();
        }

      /*  if (other.gameObject.CompareTag("50Cycle"))
        {
            other.gameObject.SetActive(false);
            count = count + 3;
            SetCount();
        }
        */
    }

    void SetCount()
    {
        countText.text = "Count: " + count.ToString();
    }

}
