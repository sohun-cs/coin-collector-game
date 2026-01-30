using System;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float playerSpeed = 5f;
    private int points = 0;
    
    private Vector3 movementInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); // GetAxisRaw দিলে তাৎক্ষণিক রেসপন্স পাবেন
        float v = Input.GetAxisRaw("Vertical");
        movementInput = new Vector3(h, 0, v);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movementInput * playerSpeed * Time.fixedDeltaTime);
    }

    public void IncreasePoints()
    {
        points++;
        Debug.Log(points);
    }
}
