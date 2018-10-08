using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

	public GameObject[] enemies;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnMosWait;
	public float spawnLeaWait;
	public  int startWait;
	public bool stop;
	int enemyCount;

	int ranEnemy;
	void Start () 
	{
		StartCoroutine (waitSpawner ());
		enemyCount = 0;
	}
	

	void Update () 
	{
		
	}




	IEnumerator waitSpawner()
	{
		yield return new WaitForSeconds (startWait);

		while (!stop) 
		{
			spawnWait = Random.Range (spawnLeaWait, spawnMosWait);
			ranEnemy = Random.Range (0, 2);
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), 1, Random.Range (-spawnValues.z, spawnValues.z));

			Instantiate (enemies [ranEnemy], spawnPosition ,enemies[ranEnemy].transform.rotation);
			enemyCount += 1;

			yield return new WaitForSeconds (spawnWait);


			if (enemyCount > 50) {
				stop = true;

			}
		}

	}

}


