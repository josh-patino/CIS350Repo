﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput; 
    public float speed = 10.0f;
    public float xRange = 14;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); 

        //transform horizontally with player input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); 

        //keep player in bounds on the neg side
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // keep player in bounds on the pos side
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y , transform.position.z);
        }
    }
}
