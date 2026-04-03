using System;
using System.Collections;
using System.Collections.Generic;
using Anthill.AI;
using UnityEngine;

public class mForward : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public float speed = 100f;

    private void Start()
    {
        
    }

    public void FixedUpdate()
    {
      GameObject alien = GameObject.FindGameObjectWithTag("Ai");
     rb.AddRelativeForce(0f, 0f, speed);
    }
    
}
