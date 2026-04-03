using Anthill.AI;
using UnityEngine;

public class alertingStates : AntAIState
{
    public StrechAlienCollectables States;

    [SerializeField] private screaminaAlien screamingAlien;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Create(GameObject aGameObject)
    {
        screamingAlien = aGameObject.GetComponent<screaminaAlien>();
        base.Create(aGameObject);
    }

    public override void Enter()
    {
        States.IsLookingForEnergy = true;
        base.Enter();
    }
}
