/*
*Josh Patino
*Assignment 2, Challenge 1 
* increase the score when the player hits a trigger
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTriggerX : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManagerX.score++; 
        }
    }
}
