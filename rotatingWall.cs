using UnityEngine;

public class rotatingWall : MonoBehaviour
{
    [SerializeField] private Vector3 roatingWall = new Vector3(0f, 0f, 100f);
    public float spped = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.Rotate(roatingWall * spped * Time.deltaTime);    
    }
}
