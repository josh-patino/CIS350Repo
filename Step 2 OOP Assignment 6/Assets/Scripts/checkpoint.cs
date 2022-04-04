/*
* Josh Patino
*  Step 2 A6
* collisin
*/     
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class checkpoint : MonoBehaviour
{
      void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Do something else here");
        }
    }
     void OnTriggerEnter(Collider other) {
         if (other.tag == "Player") {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Do something else here");
         }
     }


}



