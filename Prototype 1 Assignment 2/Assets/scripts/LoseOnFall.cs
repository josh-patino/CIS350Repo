/*
*Josh Patino
*Assignment 2, Prototype 1 
*detects if the player fell off the world, and ends the game
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//attach this script on the player
public class LoseOnFall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true; 
        }
    }
}
