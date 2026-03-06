using UnityEngine;

public class worldScanner : MonoBehaviour
{
    public GameObject[] gridOfObstacles;
    public  Node[,] grid; 
    public Vector3 size;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int x = 0; x < size.x; x++)
        {
            for (int z = 0; z < size.z; z++)

            {
                grid[x,z] = new Node();


                if (Physics.CheckBox(new Vector3(x, 0, z),
                        new Vector3(0.5f, 10f, 0.5f), Quaternion.identity))
                {
// Something is there
                    grid[x,z].isBlocked = true;
                }
            }
        }

    }
}