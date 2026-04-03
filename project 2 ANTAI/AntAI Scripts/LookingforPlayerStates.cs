using System;
using Anthill.AI;
using Tanks;
using Unity.VisualScripting;
using UnityEngine;

public class LookingforPlayerStates : AntAIState
{
    public Collectstates States;
    
    [SerializeField] private mForward forward;
    [SerializeField] private wanderingChiceknj wander;
    [SerializeField] private aggresiveAlienSight alienView;


    public override void Create(GameObject aGameObject)
    {
        forward = aGameObject.GetComponent<mForward>();
        wander = aGameObject.GetComponent<wanderingChiceknj>();
        alienView = aGameObject.GetComponent<aggresiveAlienSight>();
        base.Create(aGameObject);
        States.isLookingforplayer = true;
    }

    public override void Enter()
    {
        States.isLookingforplayer = true;
        base.Enter();
    }
}
