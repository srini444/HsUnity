using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformSpawner : MonoBehaviour {

    public GameObject plateform;
    Vector3 lastPos;
    float size;
    public bool gameOver;

	// Use this for initialization
	void Start () {
        lastPos = plateform.transform.position;
        size = plateform.transform.localScale.x;

        for (int i = 0; i < 20; i++)
        {
            SpawanPlatform();
        }

        InvokeRepeating("SpawanPlatform", 2f , 0.2f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (gameOver)
        {
            CancelInvoke("SpawanPlatform");
        }

    }

    void SpawanPlatform()
    {
        if (gameOver)
        {
            return;
        }
      int rand = Random.Range(0, 6);
        if (rand < 3)
        {
            SpawnX();
        }
        else if(rand > 3)
        {
            SpawnZ();
        }
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
