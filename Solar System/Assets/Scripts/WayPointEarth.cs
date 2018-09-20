using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointEarth : MonoBehaviour {

	public GameObject[] waypoints;
	public int waypointSize = 0;

	public float minDist;
	public float speed;

	public bool rand = false;
	public bool go = true;


	void Start () 
	{
		
	}
	

	void Update () 
	{
		float dist = Vector3.Distance (gameObject.transform.position, waypoints [waypointSize].transform.position);

		if (go) 
		{
			if (dist > minDist) 
			{
				Move ();
			} 
			else 
			{
				if (!rand) 
				{
					if (waypointSize + 1 == waypoints.Length) 
					{
						waypointSize = 0;
					} 
					else 
					{
						waypointSize++;
					}

				}
				else
				{
					waypointSize = Random.Range (0, waypoints.Length);
				}
			}

		}

	}

	public void Move()
	{
		gameObject.transform.LookAt (waypoints [waypointSize].transform.position);
		gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
	}
}
