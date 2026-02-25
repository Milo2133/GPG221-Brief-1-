using System;
using UnityEngine;

public class Avoider : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public float turnspeed = 100f;
    public float distance = 2f;

    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, transform.forward, distance))
        {
            rb.AddRelativeTorque(0f,turnspeed,0f);      
        }
    }
}
