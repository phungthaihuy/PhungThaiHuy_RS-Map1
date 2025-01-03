using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private Transform catsHoldPoint1;
    private int catCount = 0;
    
    private bool isRunning;
    private void Awake()
    {
        
        Instance = this;
    }

    private void Start()
    {
        CatsCollection.Instance.OnCatsCollection += Instance_OnCatsCollection;
    }

    private void Instance_OnCatsCollection(object sender, System.EventArgs e)
    {
        moveSpeed = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float moveDistance = (moveSpeed) * Time.deltaTime;

        Vector2 inputVector = GameInput.Instance.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);

        transform.position += moveDir * moveDistance;

        isRunning = moveDir != Vector3.zero;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * 10f);
    }

    public bool IsRunning()
    {
        return isRunning; 
    }

    public Transform GetCatFollower1()
    {
        return catsHoldPoint1;
    }
}
