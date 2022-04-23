/*
* Joshua Patino
* Assignment 8 Challenge 5
* destroys the particle attactched to the object after 5 seconds 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
