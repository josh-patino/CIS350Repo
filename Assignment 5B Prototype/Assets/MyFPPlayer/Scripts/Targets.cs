/*
* Josh Patino
*  5B
* controls the target behavior 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    // Start is called before the first frame update
   public float health = 50f; 
   public void TakeDamage(float amount)
   {
       health -= amount; 
       if (health <= 0)
       {
           Die();
       }
   }

   void Die()
   {
       {
           Destroy(gameObject); 
       }
   }
}
