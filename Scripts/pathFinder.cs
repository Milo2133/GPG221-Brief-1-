using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class pathFinder : MonoBehaviour
{
    public StrechAlienCollectables States;
    [SerializeField] public Vector3 currentPath;
    [SerializeField] private int cornerIndex;
    [SerializeField] float magnitude;
    [SerializeField] NavMeshPath paths;
    [SerializeField] LayerMask layerMask;
    [SerializeField] Transform target;
    public float distanceThreshold = 2f;

    public Color pathFollowingColor;


    private void Awake()
    {
        pathFollowingColor = new Color(Random.value, Random.value, Random.value);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
    }

    private void Update()
    {
     FindPath();   
    }

    public void FindPath()
    {
        // Calculating a Path used for the AI 
        paths = new NavMeshPath();
        
        NavMesh.CalculatePath(transform.position, target.position, layerMask, paths);
        {
            Debug.Log(paths);
        }
        //An If statement used for the NavMesh
        if (paths != null)
        {
            currentPath = paths.corners[cornerIndex];
            magnitude = Vector3.Distance(transform.position, target.position);
            
        }
        if (cornerIndex > paths.corners.Length)
        {
            cornerIndex = 1;
        }
        if (cornerIndex > paths.corners.Length)
        {
            cornerIndex = 1;
        }
    }
 
   

  


    // A Debug for the PathLine showing 
    private void OnDrawGizmos()
    {

        Gizmos.color = pathFollowingColor;
        Gizmos.DrawLine(transform.position, target.position);
    

    // Vector3 lastPos = Vector3.zero;
        //
        // if (paths != null)
        //
        //     for (var index = 0; index < paths.corners.Length; index++)
        //     {
        //         var pathCorner = paths.corners[index];
        //
        //         if (index != 0)
        //         {
        //             Gizmos.DrawLine(lastPos, pathCorner);
        //         }
        //         lastPos = pathCorner;
        //     }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
     
            States.IsScreaming = true;
        }   
    }
}
