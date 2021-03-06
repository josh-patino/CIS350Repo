/*
* Joshua Patino
* Assignment 8 Prototype 5
* responsible for difficulty button
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class DifficultyButton : MonoBehaviour
{
    public int difficulty; 
    private GameManager gameManager; 
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        button = GetComponent<Button>(); 
        button.onClick.AddListener(SetDifficulty); 
    }

    void SetDifficulty()
    {
        gameManager.StartGame(difficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
