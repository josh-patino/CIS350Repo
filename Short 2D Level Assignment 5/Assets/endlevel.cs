/*
 * Josh Patino
 * 5A
 * file for the text box to display end of level
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class endlevel : MonoBehaviour
{
    public Text endText; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player")) {
			endText.text = "You Win!!!";  
			
		}
	}
}
