/*
*Josh Patino
*Assignment 2, Prototype 1 
*keeps track of the score, and checks conditions to end the game
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver; 
    public static bool won; 
    public static int score; 
    
    public Text textbox; 
    
    void Start()
    {
        gameOver = false; 
        won = false; 
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        // if game is not over, display score
        if (! gameOver)
        {
            textbox.text = "Score: " + score; 
        }
        //if the win conditon: 3 or mroe points
        if (score >= 3)
        {
            won = true; 
            gameOver = true; 
        }
        
        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You win \nPress R to try again!"; 
            } 
            else
            {
                textbox.text = "You lose \nPress R to try again"; 
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
