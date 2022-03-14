/*
* Josh Patino
*  5B
* contorls the text display
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIManager : MonoBehaviour
{
public Text winText;
private bool FinishLine = false;

void Start()
{
    FinishLine = false;
}

void OnTriggerEnter(Collider col)
{
    if (col.tag == "Player")
    {
        FinishLine = true;
        winText.text = "You Win";
    }
}
}
