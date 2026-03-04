using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class AImanager : MonoBehaviour
{
    public void ToggleMovement()
    {
        foreach (moveForward item in FindObjectsOfType<moveForward>())
        {
         item.enabled = !item.enabled;   
        }
    }

    public void ToggleWander()
    {
        foreach (wander item in FindObjectsOfType<wander>())
        {
         item.enabled = !item.enabled;   
        }   
    }
    

    public void turning()
    {
        foreach(turning item in FindObjectsOfType<turning>())
        {
        item.enabled = !item.enabled;    
        }
    }

    public void Allignment()
    {
        foreach (Allign item in FindObjectsOfType<Allign>())
        {
        item.enabled = !item.enabled;    
        }    
    }

    public void Cohesion()
    {
        foreach (Cohesion item in FindObjectsOfType<Cohesion>())
        {
            item.enabled = !item.enabled;
        }
    }
    public void seperation()
    {
        foreach (seperation item in FindObjectsOfType<seperation>())
            {
            item.enabled = !item.enabled;
            }
    }
    public void Neighbours()
    {
        foreach (Neighbours item in FindObjectsOfType<Neighbours>())
        {
            item.enabled = !item.enabled;
        }
    }

    public void PathFinding()
    {
        foreach (pathFinding item in  FindObjectsOfType<pathFinding>())
        {
         item.enabled = !item.enabled;   
        }   
    }

    public void turnTowardsTarget()
    {
        foreach (turnTowards item in FindObjectsOfType<turnTowards>())
        {
         item.enabled = !item.enabled;   
        }   
    }

    public void pathfindSpawn()
    {
        foreach(pathfindtoSpawn item in FindObjectsOfType<pathfindtoSpawn>())
        {
         item.enabled = !item.enabled;    
        }   
    }

    public void turnTowardTosSpawn()
    {
        foreach(turntowardsSpanw item in FindObjectsOfType<turntowardsSpanw>())
        {
        item.enabled = !item.enabled;    
        }
    }
}
