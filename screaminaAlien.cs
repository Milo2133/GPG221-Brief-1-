using System;
using System.Collections;
using UnityEngine;

public class screaminaAlien : MonoBehaviour
{
    public StrechAlienCollectables States;
    public AudioSource Screaming;
    public bool turnOffSound = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    screaming();
    StartCoroutine(StopScreamingCoroutine());
 
    }
    

    public void screaming()
    {
        if (States.IsLookingForEnergy = true)
        {
            Screaming.PlayOneShot(Screaming.clip); 
        } 
    }

    private IEnumerator StopScreamingCoroutine()
    {
        yield return new WaitForSeconds(1f);
        {
         Screaming.Stop();   
         States.IsLookingForEnergy = false;
        }
    }
}
