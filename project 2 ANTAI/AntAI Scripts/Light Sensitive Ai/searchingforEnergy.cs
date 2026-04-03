using Anthill.AI;
using Anthill.Animation;
using UnityEngine;

public class searchingforEnergy : AntAIState
{
    public StrechAlienCollectables alienStates;
    [SerializeField] pathFinder energyFinding;
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
        alienStates = aGameObject.GetComponent<StrechAlienCollectables>();
        base.Create(aGameObject);
    }

    public override void Enter()
    {
        alienStates.IsLookingForEnergy = true;
    }
}
