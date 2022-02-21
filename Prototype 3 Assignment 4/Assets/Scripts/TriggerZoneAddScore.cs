/*
* Josh Patino
* Prototype 3 Assignment 4
* when player hits the trigger above the obstacle, score is increased
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour
{
    private UIManager userIManager;
    private bool triggered = false; 
    // Start is called before the first frame update
    void Start()
    {
      userIManager = GameObject.FindObjectOfType<UIManager>();   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true; 
            userIManager.score++; 
        }
    }
    // Update once per 
}
