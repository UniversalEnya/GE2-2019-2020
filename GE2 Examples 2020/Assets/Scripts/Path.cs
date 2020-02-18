using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    //public List<Vector3> waypoints;
    public List<Vector3> waypoints;

    public GameObject path;

    public bool IsLooped = false;

    private void Awake()
    {
        
    }


    public void OnDrawGizmos()
    {
        waypoints = new List<Vector3>(5);
        
        waypoints.Add(path.transform.position);
        waypoints.Add(path.transform.GetChild(0).position);
        waypoints.Add(path.transform.GetChild(1).position);
        waypoints.Add(path.transform.GetChild(2).position);
        waypoints.Add(path.transform.GetChild(3).position);

        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(waypoints[0], 1);
        Gizmos.DrawLine(waypoints[0], waypoints[1]);
        Gizmos.DrawSphere(waypoints[1], 1);
        Gizmos.DrawLine(waypoints[1], waypoints[2]);
        Gizmos.DrawSphere(waypoints[2], 1);
        Gizmos.DrawLine(waypoints[2], waypoints[3]);
        Gizmos.DrawSphere(waypoints[3], 1);
        Gizmos.DrawLine(waypoints[3], waypoints[4]);
        Gizmos.DrawSphere(waypoints[4], 1);

        if (IsLooped == true)
        {
            Gizmos.DrawLine(waypoints[4], waypoints[0]);
        }
    }
}
