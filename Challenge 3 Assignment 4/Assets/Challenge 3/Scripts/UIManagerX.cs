/*
* Josh Patino
* Challenge 3 Assignment 4
* controls the UI/score text
*/
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 
public class UIManagerX : MonoBehaviour
{
     public int score = 0;
    public Text scoreText; 
    public PlayerControllerX playerControllerScript; 
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
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>(); 
        }

        scoreText.text = "Score: 0"; 
    }

    // Update is called once per frame
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
        // win condition: 30
        if (score >= 17)
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
