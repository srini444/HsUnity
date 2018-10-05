using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformSpawner : MonoBehaviour {

    public GameObject plateform;
    Vector3 lastPos;
    float size;

	// Use this for initialization
	void Start () {
        lastPos = plateform.transform.position;
        size = plateform.transform.localScale.x;

        for (int i = 0; i < 5; i++)
        {
            SpawnZ();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnX()
    {
        Vector3 pos = lastPos;
        pos.x += size;
        lastPos = pos;
        Instantiate(plateform, pos, Quaternion.identity);

    }

    void SpawnZ()
    {
        Vector3 pos = lastPos;
        pos.z += size;
        lastPos = pos;
        Instantiate(plateform, pos, Quaternion.identity);
    }
}
