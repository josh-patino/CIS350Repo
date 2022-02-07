/*
*Josh Patino
*Assignment 3, Prototype 2 
* script responsible for detecting collisons between objects
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript; 

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject); // destroy animal
        Destroy(gameObject); //destroy food
    }
}
