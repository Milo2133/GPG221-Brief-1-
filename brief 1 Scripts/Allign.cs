using System.Collections.Generic;
using UnityEngine;

public class Allign : MonoBehaviour
{
    // Variable pointing to your Neighbours component
    public Neighbours neighbours;
    public Rigidbody rb;
    public float force = 100f;
    public Vector3 cross;


    void FixedUpdate()
    {
        // Some are Torque, some are Force		
        // Some are Torque, some are Force		
        Vector3 targetDirection = CalculateMove(neighbours.neighbourList);
		
        // Cross will take YOUR direction and the TARGET direction and turn 
        // it into a rotation force vector. It CROSSES through both at 90 degrees
        Vector3 cross = Vector3.Cross(transform.forward, targetDirection);
        // Debug.DrawRay(transform.position, cross, Color.red);
        
// TODO: Visualise the cross product vector/direction

        rb.AddTorque(cross * force);    
    }

    public Vector3 CalculateMove(List<GameObject> neighbours)
    {
        if (neighbours.Count == 0)
            return Vector3.zero;

        Vector3 alignmentDirection = Vector3.zero;

        // Average of all neighbours directions
        // I’m using a list of transforms in my neighbours script, you might be using GameObjects etc
        foreach (GameObject item in neighbours)
        {
            alignmentDirection += item.transform.position;
        
        }

        alignmentDirection /= neighbours.Count;

// TODO: Draw a debug line for the DESIRED direction (Your character won’t immediately be snapping to this, line, they’re GRADUALLY turn to it)

        return alignmentDirection;
    }
}

