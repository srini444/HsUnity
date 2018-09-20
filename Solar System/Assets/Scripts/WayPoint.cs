using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class WayPoint : MonoBehaviour {

	public List<Transform> waypoint = new List<Transform> ();

	void Start () 
	{
		
	}
	

	void Update () 
	{
		
//			waypoint.Clear ();
//
//		Transform[] tem = GetComponentInChildren<Transform> ();
//
//		if(tem.Length > 0)
//		{
//			foreach (Transform t in t) 
//			{
//				waypoint.Add (t);
//			}
//		}
	} 

	void OnDrawGizmos()
	{
		if (waypoint.Count > 0) 
		{
			Gizmos.color = Color.green;
			foreach (Transform t in waypoint)
				Gizmos.DrawSphere (t.position, 1f);
			Gizmos.color = Color.red;
			for (int a = 0; a < waypoint.Count - 1; a++)
				Gizmos.DrawLine (waypoint [a].position, waypoint [a + 1].position);
		}
	}
}
