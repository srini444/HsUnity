using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject EnemySpawer1;
    Vector3 lastPos;
    float size;
	
	void Start ()
    {
        lastPos = EnemySpawer1.transform.position;
        size = EnemySpawer1.transform.localScale.x;
        for(int i =0; i<4; i++)
        {
            SpawnX();
        }
	}
	
	
	void Update ()
    {
		
	}

    void SpawnX()
    {
        Vector3 pos = lastPos;
        pos.x += size;
        lastPos += pos;
        Instantiate(EnemySpawer1, pos, Quaternion.identity);
    }
    void SpawnY()
    {

    }
}
