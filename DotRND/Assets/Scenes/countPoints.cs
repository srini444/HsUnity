using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class countPoints : MonoBehaviour {

    public Text countText;
    private int count;
    Rigidbody rbmove;

    moveSwipe move ;

    AudioSource coinSound;
    void Start ()
    {
        count = 0;
        SetCount();
        rbmove = GetComponent<Rigidbody>();
        coinSound = GetComponent<AudioSource>();
    }
	
	
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("1"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 1;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();

        }
        if (other.gameObject.CompareTag("2"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 2;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("3"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 3;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("4"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 4;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("5"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 5;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }
        if (other.gameObject.CompareTag("6"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 6;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("7"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 7;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("8"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 8;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("9"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 9;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }
        if (other.gameObject.CompareTag("10"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 10;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("11"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 11;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("12"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 12;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("13"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 13;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }
        if (other.gameObject.CompareTag("14"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 14;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("15"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 15;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("16"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 16;
            SetCount();
            rbmove.isKinematic = true;
        }

        if (other.gameObject.CompareTag("17"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 17;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("18"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 18;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("19"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 19;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("20"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 20;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

        if (other.gameObject.CompareTag("50"))
        {
            Debug.Log(other.gameObject.name);
            count = count + 50;
            SetCount();
            rbmove.isKinematic = true;
            coinSound.Play();
        }

    }



    void SetCount()
    {
        countText.text = "POINTS : " + count.ToString();
    }


}
