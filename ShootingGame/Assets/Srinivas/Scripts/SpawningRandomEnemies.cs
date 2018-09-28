using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningRandomEnemies : MonoBehaviour {

	public GameObject[] enemies;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnMosWait;
	public float spawnLeaWait;
	public  int startWait;
	public bool stop;

	int ranEnemy;
	void Start () 
	{
		StartCoroutine (waitSpawner ());
	}
	

	void Update () 
	{
		spawnWait = Random.Range (spawnLeaWait, spawnMosWait);
	}

	IEnumerator waitSpawner()
	{
		yield return new WaitForSeconds (startWait);

		while (!stop) 
		{
			ranEnemy = Random.Range (0, 2);
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), 1, Random.Range (-spawnValues.z, spawnValues.z));

			Instantiate (enemies [ranEnemy], spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);

			yield return new WaitForSeconds (spawnWait);

		}

	}

}
