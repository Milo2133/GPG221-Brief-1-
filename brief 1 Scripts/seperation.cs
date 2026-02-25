using System;
using System.Collections.Generic;
using UnityEngine;

public class seperation : MonoBehaviour
{

    // Variable pointing to your Neighbours component
    public Neighbours neighbours;
    public Rigidbody rb;
    public float force = -100f;
    public Vector3 cross;
    public float MaxNeigbourdistance = 4f;

    private void FixedUpdate()
    {
        foreach (GameObject item in neighbours.neighbourList) 
        {
         Vector3 DirectiontoTarget = (neighbours.transform.position - item.transform.position).normalized;
         rb.AddForce(DirectiontoTarget * force);
        }
    }
}