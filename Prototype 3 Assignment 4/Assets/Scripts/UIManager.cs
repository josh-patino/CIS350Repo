/*
* Josh Patino
* Prototype 3 Assignment 4
* UI manager script 
*
*/
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText; 
    public PlayerController playerControllerScript; 
    public bool won = false; 
    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>(); 
        }

        scoreText.text = "Score: 0"; 
    }

    void Update()
    {
        //display score during the game
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }
        // lose condition
        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!" + "\n" + "Press R to Try again!";   
        }
        // win condition: 10
        if (score >= 10)
        {
            playerControllerScript.gameOver = true; 
            won = true; 

            //playerControllerScript.StopRunning(); 
            scoreText.text = "You win!" + "\n" + "Press R to Try again!"; 
        }

        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }
}
