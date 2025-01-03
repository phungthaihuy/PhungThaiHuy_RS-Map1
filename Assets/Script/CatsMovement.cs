using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatsMovement : MonoBehaviour
{
    //public static CatsMovement Instance { get; private set; }

    //private void Awake()
    //{
    //    if (Instance == null) { Instance = this; }
    //}
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] public float speed = 2f;
    private int waypointIndex = 0;
    private bool isRunning;
    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = new Vector3(transform.position.x, 0f, transform.position.z);

        isRunning = moveDir != Vector3.zero;
       

        if (Vector3.Distance(waypoints[waypointIndex].transform.position, transform.position) < .1f) {
            waypointIndex++;
            if (waypointIndex >= waypoints.Length) { 
                waypointIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, Time.deltaTime * speed);

        transform.LookAt(waypoints[waypointIndex].transform.position);


    }

    public bool IsRunning()
    {
        return isRunning;
    }
}
