using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartArrow : MonoBehaviour {

	// Use this for initialization
	IEnumerator waitAndDestroy ()
    {

        yield return new WaitForSeconds(4);
        Dot.manager.CreateDot();
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Cube")
        {
            Destroy(gameObject);
        }
    }

    public void DestroyArrow()
    {
        StartCoroutine(waitAndDestroy());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Board") {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().isKinematic = true;

        }
    }

}
