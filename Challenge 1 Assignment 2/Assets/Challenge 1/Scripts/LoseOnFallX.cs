/*
*Josh Patino
*Assignment 2, Challenge 1 
*file responsible when a player goes below -51 or above 81
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFallX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.y >= 80) || (transform.position.y <= -51))
        {
            ScoreManagerX.gameOver = true;
        }
    }
}
