/*
*Josh Patino
*Assignment 2, Challenge 1 
*makes sure that only once is the trigger able to be hit
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddOnceX : MonoBehaviour
{
    // Start is called before the first frame update
   private bool triggered = false; 

   private void OnTriggerEnter(Collider other) 
   {
       if(other.CompareTag("Player") && !triggered) 
       {
           triggered = true;
           ScoreManagerX.score++;
       }
   }
}
