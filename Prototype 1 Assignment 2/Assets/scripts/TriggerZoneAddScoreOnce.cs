/*
*Josh Patino
*Assignment 2, Prototype 1 
*If player hits the trigger, accurately add 1 to the score
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this to a trigger zone

public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false; 
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true; 
            ScoreManager.score++; 
        }
    }
}
