using System.Collections;
using Anthill.AI;
using UnityEngine;

public class turntowardsPlayer : MonoBehaviour
{
    public Collectstates states;
    
    [SerializeField] private Rigidbody rb;
    [SerializeField] Transform targetObject;
    [SerializeField] private float turnSpeed = 2f;
    [SerializeField] Vector3 targetPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir;
    
        if (targetObject)
        {
            // Has a target gameobject
            targetDir = (targetObject.position - transform.position).normalized;
            float angle = Vector3.SignedAngle(transform.forward, targetDir, transform.up);
            rb.AddRelativeTorque(0f,angle,0f);
            StartCoroutine(drawWrapon());
        }
    }

    private IEnumerator drawWrapon()
    {
      yield return new WaitForSeconds(3f);
      states.isCanSeeplayer = true;
      states.isweapondDrawn = false;
      states.isLookingforplayer = false;
    }
}
