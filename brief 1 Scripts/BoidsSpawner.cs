using UnityEngine;

public class BoidsSpawner : MonoBehaviour
{
    [SerializeField] private int amount;
    [SerializeField] private GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     for (int i = 0; i < amount; i++)
        //     {
        //         Instantiate(prefab, transform.position,transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0));
        //     }
        // }
    }

    public void SpawnAI()
    {
        for (int i = 0; i < amount; i++)
        {
            Instantiate(prefab, transform.position,transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0));
        }  
    }
    
}
