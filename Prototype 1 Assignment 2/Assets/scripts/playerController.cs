/*
*Josh Patino
*Assignment 2, Prototype 1 
*controls the player
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed; 
    public float turnSpeed; 
    public float forwardInput;
    public float horizontalInput; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical"); 
        horizontalInput = Input.GetAxis("Horizontal"); 
        //move forward, with forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        
    }
}
