using System;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class pathfindtoSpawn : MonoBehaviour
{
    public Vector3 curretnPath;
    [SerializeField] private int cornerIndex;
    [SerializeField] private float magnitude;
    [SerializeField] private NavMeshPath path;
    [SerializeField] private LayerMask Everything;
    [SerializeField] private Transform target;

    private pathFinding pathFind;
    private pathfindtoSpawn spawn;
    private turnTowards tunrtowardstarget;
    private turntowardsSpanw turntospawm;
    
    private Color pathFinderColor;

    private void Awake()
    {
     pathFinderColor = new Color(Random.value, Random.value, Random.value);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     pathFind = GetComponent<pathFinding>();
     spawn = GetComponent<pathfindtoSpawn>();
     tunrtowardstarget = GetComponent<turnTowards>(); 
     turntospawm = GetComponent<turntowardsSpanw>();
    }

    // Update is called once per frame
    void Update()
    {
        path =  new NavMeshPath();
        NavMesh.CalculatePath(transform.position, target.position, Everything, path);
        {
            Debug.Log(path);
        }
        curretnPath = path.corners[cornerIndex];
        magnitude = Vector3.Distance(transform.position, target.position);

        if(cornerIndex > path.corners.Length)
        {
            cornerIndex = 1;
        }

        if (cornerIndex > path.corners.Length)
        {
            cornerIndex = 1;
        }
    }

    private void OnDrawGizmos()
    {
    Gizmos.color = pathFinderColor;
    Gizmos.DrawLine(transform.position,target.position);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("spawnTarget"))
        {
            pathFind.enabled = true;
            spawn.enabled = false;
            tunrtowardstarget.enabled = true;
            turntospawm.enabled = false;
        }
    }
}
