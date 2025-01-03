using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatHoldPoint : MonoBehaviour
{
    private int catCount = 0;
    // Update is called once per frame
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            if (transform.GetChild(i) == true) {
                catCount = catCount +1;
            }
        }
    }
}
