/*
*Josh Patino
*Assignment 2, Prototype 1 
* detects if the player collides with the trigger
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this to the player
public class PlayerEnterTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++; 
        }
    }
}
