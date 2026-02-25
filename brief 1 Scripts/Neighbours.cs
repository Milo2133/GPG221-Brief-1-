using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Neighbours : MonoBehaviour
{
    public List<GameObject> neighbourList;
    [SerializeField] private float distamce = 2f;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Entities"))
        {
            neighbourList.Add(collision.gameObject);
        }
    }

    private void OnTriggerExit(Collider collison)
    {
        if (collison.gameObject.CompareTag("Entities"))
        {
            neighbourList.Remove(collison.gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, transform.forward, distamce))
        {
            Debug.Log("Hit Obstacles");
        }
    }
}
