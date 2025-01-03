using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAnimation : MonoBehaviour
{
    private Animator anim;
    private const string IS_RUNNING = "Run";
    [SerializeField] private CatsMovement catMovement;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool(IS_RUNNING, catMovement.IsRunning());
    }
}
