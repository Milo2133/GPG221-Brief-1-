using System;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float distance = 1.5f;
    public float speed = 300f;
    public float slowSpeed = 800f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
       {

    }

    private void FixedUpdate()
    {
        rb.AddRelativeForce(0f, 0f, speed);
        {
            if (Physics.Raycast(transform.position, transform.forward, distance))
            {
                rb.AddRelativeForce(0f, 0f,(slowSpeed));
            }
        }
    }
}
