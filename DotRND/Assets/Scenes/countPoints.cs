using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class countPoints : MonoBehaviour {

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

    void OncollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("1"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 1;
            SetCount();
            
            //  resetTransform();
        }

        if (other.gameObject.CompareTag("2"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 2;
            SetCount();
            // Destroy(this.gameObject, 3f);
            
            //  resetTransform();
        }

        if (other.gameObject.CompareTag("3"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 3;
            SetCount();
            
            // resetTransform();
            // Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("4"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 4;
            SetCount();
            
            // resetTransform();
        }

        if (other.gameObject.CompareTag("5"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 5;
            SetCount();
            
            //resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("6"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 6;
            SetCount();
            
            //resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("7"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 7;
            SetCount();
            
            // resetTransform();
        }

        if (other.gameObject.CompareTag("8"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 8;
            SetCount();
            
            // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("9"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 9;
            SetCount();
            
            // resetTransform();
            // Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("10"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 10;
            SetCount();
            
            // resetTransform();
        }

        if (other.gameObject.CompareTag("11"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 11;
            SetCount();
            
            // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("12"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 12;
            SetCount();
            
            //resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("13"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 13;
            SetCount();
            
            // resetTransform();
            // Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("14"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 14;
            SetCount();
            
            // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("15"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 15;
            SetCount();
            
            // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("16"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 16;
            SetCount();
            
            // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("17"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 17;
            SetCount();
            
            // resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("18"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 18;
            SetCount();
            
            //Destroy(this.gameObject, 3f);
            //resetTransform();
        }

        if (other.gameObject.CompareTag("19"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 19;
            SetCount();
            
            //resetTransform();
            //Destroy(this.gameObject, 3f);
        }

        if (other.gameObject.CompareTag("20"))
        {
            
            Debug.Log(other.gameObject.name);
            count = count + 20;
            SetCount();
            
            //Destroy(this.gameObject, 3f);
            // resetTransform();
        }





    }
    void SetCount()
    {
        countText.text = "Points: " + count.ToString();
    }
}
