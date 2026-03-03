
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turning : MonoBehaviour
{
    [SerializeField] private float turningSpeed = 1000f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float distance = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position,transform.forward, distance))
        {
        rb.AddRelativeTorque(0,turningSpeed,0);
        {
         Debug.DrawRay(transform.position,transform.forward,Color.red);   
        }
        }
    }

    // private void OnDrawGizmos()
    // {
    // Debug.DrawRay(transform.position,transform.forward,Color.red);
    // }
}
