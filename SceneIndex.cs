using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneIndex : MonoBehaviour
{
public int levelIndex;


    public void PathfindingAi()
    {
     SceneManager.LoadScene(levelIndex);
    }
    
    public void WanderAi()
    {
        SceneManager.LoadScene(levelIndex);
    }
    
    public void BoidAi()
    {
        SceneManager.LoadScene(levelIndex);
    }
    
    public void AvoidAi()
    {
        SceneManager.LoadScene(levelIndex);
    }
}
