/*
* Josh Patino
* Prototype 3 Assignment 4
* script for the obstacle to move left
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private float leftBound = -10;
    private PlayerController playerControllerScript; 
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //if we are out of bounds, the object will be destroyed
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject); 
        }

    }
}
