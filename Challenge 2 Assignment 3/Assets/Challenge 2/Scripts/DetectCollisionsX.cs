/*
*Josh Patino
*Assignment 3, Prototype 2 
* detects collions between the dogs and balls
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScoreX displayScoreScript; 

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScoreX>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject); // destroy animal
        //Destroy(gameObject); //destroy food
        
        //Destroy(gameObject); //destroy food
    }
}
