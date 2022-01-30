/*
*Josh Patino
*Assignment 2, Prototype 1 
*camera that follows player
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollowPlayer : MonoBehaviour
{
    public GameObject player; 
    private Vector3 offset = new Vector3(0,5,-10);
    

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
