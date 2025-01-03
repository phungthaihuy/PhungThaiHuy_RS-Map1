using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObstacleSpawn : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private GameObject xPosMin;
    [SerializeField] private GameObject xPosMax;
    [SerializeField] private GameObject zPosMin;
    [SerializeField] private GameObject zPosMax;


    // Start is called before the first frame update
    void Start()
    {
        float randomX = Random.Range(xPosMin.transform.position.x, xPosMax.transform.position.x);
        float randomZ = Random.Range(zPosMin.transform.position.z, zPosMin.transform.position.z);

        Vector3 randomPosition = new Vector3(randomX, 0f, randomZ);
        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }
}
