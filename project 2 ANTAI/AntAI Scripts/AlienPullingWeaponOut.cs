using System;
using Anthill.AI;
using Tanks;
using UnityEngine;

public class AlienPullingWeaponOut : MonoBehaviour
{
    public GameObject gun;

    public Collectstates States;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate()
    {
      GetComponentInParent<GameObject>().SetActive(true);
        gun.SetActive(true);
        {
            GetComponentInParent<Collectstates>().isCanSeeplayer = true;
            GetComponentInParent<Collectstates>().isweapondDrawn = true;
        }
    }
}
