using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Life : MonoBehaviour
{
    private const string ENEMY = "Enemy";
    // Start is called before the first frame update
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(ENEMY)) {
            StartCoroutine(Die());
        }
    }

    private IEnumerator Die() {
        //player.SetActive(false);
        //rb.freezeRotation = true;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
