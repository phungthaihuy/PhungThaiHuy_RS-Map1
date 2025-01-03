using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private GameObject xPosMin;
    [SerializeField] private GameObject xPosMax;
    [SerializeField] private GameObject zPosMin;
    [SerializeField] private GameObject zPosMax;

    private int baseEnemy = 1;
    //private int scalingFactor = 1;
    private int cunnrentLevel;
    private void Awake()
    {
        cunnrentLevel = LevelManager.Instance.currentLevel;
    }
    // Start is called before the first frame update
    void Start()
    {
            SpawnEnemy();
        
    }
    private void SpawnEnemy() {
        int enemyCount = baseEnemy + cunnrentLevel;
        
        for (int i = 0; i < enemyCount; i++) {
            float randomX = Random.Range(xPosMin.transform.position.x, xPosMax.transform.position.x);
            float randomZ = Random.Range(zPosMin.transform.position.z, zPosMin.transform.position.z);

            Vector3 randomPosition = new Vector3(randomX, 0f, randomZ);
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
        }
        
    }
    private void Update()
    {
        
    }
}
