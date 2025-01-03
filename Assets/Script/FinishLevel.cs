using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public static FinishLevel Instance { get; set; }
    private void Awake()
    {
        Instance = this;
    }

    private const string PLAYER = "Player";
    
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(PLAYER))
        {
            CompleteLevel();
            LevelManager.Instance.LevelUp();
        }

    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
