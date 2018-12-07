using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDot : MonoBehaviour {

	[SerializeField]
	GameObject dot;

	public void Spawn()
	{
		Instantiate (dot, new Vector3(0f, 1f, -8f), Quaternion.identity);
	}
}
