using UnityEngine;

public class Cohesion : MonoBehaviour
{
    public Neighbours neighbours;
    public Rigidbody rb;
    public float force = -100f;
    public Vector3 cross;
    public float MaxNeigbourdistance = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject item in neighbours.neighbourList) 
        {
            Vector3 DirectiontoTarget = (neighbours.transform.position - transform.position).normalized;
            rb.AddForce(DirectiontoTarget * force);
        }
    }
}
