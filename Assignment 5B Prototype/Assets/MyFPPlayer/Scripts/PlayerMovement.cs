/*
* Josh Patino
*  5B
* controls the player movement 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
public float forwardsForce = 40f;
public float sidewaysForce = 40f;
public Vector3 up;
public Vector3 down;
public float jumpForce = 4f;

public Rigidbody rb;

void Start()
{
    up = new Vector3(0.0f, 2f, 0.0f);
    down = new Vector3(0.0f, -2f, 0.0f);
}
void Update()
{
    MovePlayer();
}

void MovePlayer()
{
    if (Input.GetKey(KeyCode.W))
    {
        rb.AddForce(up * jumpForce, ForceMode.Impulse);
    }
    if (Input.GetKey(KeyCode.S))
    {
        rb.AddForce(down * jumpForce, ForceMode.Impulse);
    }
    if (Input.GetKey(KeyCode.A))
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    if (Input.GetKey(KeyCode.D))
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
}