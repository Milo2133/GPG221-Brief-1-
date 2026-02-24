using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class wander : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [Range(50,100)]
    [SerializeField] private float amount;


    private void FixedUpdate()
    {
        rb.AddRelativeTorque(0f,(Random.Range(-amount, amount)),0f);
    }
}
