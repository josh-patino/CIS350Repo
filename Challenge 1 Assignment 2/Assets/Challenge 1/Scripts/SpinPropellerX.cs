/*
*Josh Patino
*Assignment 2, Challenge 1 
*allows the propeller to spin on the plane
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,speed * Time.fixedDeltaTime, Space.Self);
    }
}
