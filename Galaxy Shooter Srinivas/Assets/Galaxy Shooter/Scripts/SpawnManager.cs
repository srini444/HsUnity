using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private GameObject[] powerups;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(EnemySpawnRoutine());
        StartCoroutine(PowerUpSpawnRoutine());
	}
	// create a corotine to spawn every 5 sec
    IEnumerator EnemySpawnRoutine()
    {
        while (true)
        {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-7f, 7f), 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
    IEnumerator PowerUpSpawnRoutine()
    {
        while (true)
        {
            int randomPowerup = Random.Range(0, 3);
            Instantiate(powerups[randomPowerup], new Vector3(Random.Range(-7f, 7f), 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }

}
