using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int waypntIdx;

    [SerializeField] private float moveSpeed = 2f;
    void Update()
    {   // Checks distance between object and the current waypoint 
        if (Vector2.Distance(waypoints[waypntIdx].transform.position,
            transform.position) < .1f)
        {
            waypntIdx++;
            // checks if it has reached the last waypoint
            if (waypntIdx >= waypoints.Length)
            {
                waypntIdx = 0;
            }
        }
        // actually does the moving of the object to the target waypoint based on moveSpeed
        transform.position = Vector2.MoveTowards(transform.position,
                                                    waypoints[waypntIdx].transform.position,
                                                    Time.deltaTime * moveSpeed);
    }
}
