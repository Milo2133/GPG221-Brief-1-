using Anthill.AI;
using UnityEngine;
using Anthill.Utils;


public enum Stretching_Alien_Ai
{
    canScream = 0,
    Lookingforenergy = 1
 }

public class StrechAlienCollectables : MonoBehaviour , ISense
{
    public bool IsScreaming;
    public bool IsLookingForEnergy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectConditions(AntAIAgent aAgent, AntAICondition aworldState)
    {
        aworldState.Set(Stretching_Alien_Ai.canScream, IsScreaming);
        aworldState.Set(Stretching_Alien_Ai.Lookingforenergy,IsLookingForEnergy);
    }
}
