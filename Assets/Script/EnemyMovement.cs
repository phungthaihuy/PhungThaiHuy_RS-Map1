using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] public float speed = 2f;

    private bool isRunning;

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = new Vector3(transform.position.x, 0f, transform.position.z);
        isRunning = moveDir != Vector3.zero;
        transform.position = Vector3.MoveTowards(transform.position, Player.Instance.transform.position, Time.deltaTime * speed);
        
        transform.LookAt(Player.Instance.transform.position);
    }

    public bool IsRunning()
    {
        return isRunning;
    }
}
