using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatsCollection : MonoBehaviour
{
    public event EventHandler OnCatsCollection;
    
    public static CatsCollection Instance { get; private set; }

    private int catsCount = 0;
    private void Awake()
    {
        if (Instance == null) { Instance = this; }
    }
    [SerializeField] private Transform catHoldPoint1;
     private CatsMovement catsMovement;
    private const string CATS = "Cats";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(CATS))
        {
            
            Destroy(other.gameObject);
            Transform cat = Instantiate(other.gameObject.transform, catHoldPoint1.transform);
            cat.localPosition = Vector3.zero;

            OnCatsCollection?.Invoke(this, EventArgs.Empty);
            //catsMovement.speed = 0f;
        }
    }
}
