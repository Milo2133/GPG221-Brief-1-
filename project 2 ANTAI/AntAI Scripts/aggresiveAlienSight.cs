using System.Collections.Generic;
using Anthill.AI;
using UnityEngine;

public class aggresiveAlienSight : MonoBehaviour
{
    public float maxAngle = 100;
    public int rays = 10;

    public List<GameObject> thingsSeen;

    public bool seesPlayer;
    
    [SerializeField] private LayerMask Player;

    [SerializeField] private Collectstates states;


    private void Awake()
    {
        Player = LayerMask.GetMask("players");
    }

    private void FixedUpdate()
    {
        states.isLookingforplayer = true;
        gameObject.GetComponent<Collectstates>();
        float currentAngle = -maxAngle / 2f;

        for (int i = 0; i < rays; i++)
        {
            Vector3 dir = Quaternion.Euler(0, currentAngle, 0) * transform.forward;
            // Debug.DrawRay(transform.position, dir * 10000f, Color.green);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(dir), out hit, 1000f, Player))
            {
                if (!thingsSeen.Contains(hit.collider.gameObject))
                {
                    thingsSeen.Add(hit.collider.gameObject);
                    seesPlayer = true;
                }
            }
            float spreadAngle = maxAngle / (rays - 1);
            currentAngle += spreadAngle;
        }

        if (seesPlayer)
        {
            // states.isLookingforplayer = false;
            states.isCanSeeplayer = true;
         Debug.Log("Sees Player");   
        }
    }
}
