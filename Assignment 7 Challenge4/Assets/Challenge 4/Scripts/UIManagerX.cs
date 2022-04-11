/*
* Joshua Patino
* Assignment 7 Challenge 4
* manages the UI of the game
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class UIManagerX : MonoBehaviour
{
    public int wave = 1;
    public Text waveText; 
    public Text instructionsText; 
    public PlayerControllerX playerControllerScript; 
    public bool won = false; 
    // Start is called before the first frame update
    void Start()
    {        
          if (waveText == null)
        {
            waveText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>(); 
        }

        waveText.text = "wave: 0"; 
    }

    // Update is called once per frame void Update()
    void Update()
    {
        instructionsText.text = "Shoce the balls into the other net! hit the power up for a boost! \n press space"; 

        if (Input.GetKey(KeyCode.Space))
        {
            instructionsText.gameObject.SetActive(false); 
        }

        //display wave during the game
        if (!playerControllerScript.gameOver)
        {
            waveText.text = "Wave: " + wave;
        }
        // lose condition
        if (playerControllerScript.gameOver && !won)
        {
            waveText.text = "You Lose!" + "\n" + "Press R to Try again!";   
        }
        // win condition: 10
        if (wave >= 10)
        {
            playerControllerScript.gameOver = true; 
            won = true; 

            //playerControllerScript.StopRunning(); 
            waveText.text = "You win!" + "\n" + "Press R to Try again!"; 
        }

        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }
}
