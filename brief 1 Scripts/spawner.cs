using System;
using UnityEngine;
using Random = System.Random;

public class spawner : MonoBehaviour
{
    [SerializeField] private int amount = 1;
    [SerializeField] private GameObject prefab;

    private void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     for (int i = 0; i < amount; i++)
        //     {
        //         Instantiate(prefab, transform.position, Quaternion.identity);
        //     }
        // }
    }
    public void Spawn()
    {
        for (int i = 0; i < amount; i++)
        {
         Instantiate(prefab,transform.position,Quaternion.identity);
        }
    }
}
