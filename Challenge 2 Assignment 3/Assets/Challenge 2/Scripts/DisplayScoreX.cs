/*
*Josh Patino
*Assignment 3, Prototype 2 
* responsible for displaying score
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DisplayScoreX : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textbox; 
    public int score = 0; 
    void Start()
    {
        //set text component reference 
        textbox = GetComponent<Text>(); 

        textbox.text = "Score: 0"; 
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score; 
    }
}
