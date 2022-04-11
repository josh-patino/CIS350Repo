﻿/*
* Joshua Patino
* Assignment 7 Prototype 4
* controls the player script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool gameOver = false; 
    private UIManager UIManagerX;
    private Rigidbody playerRb; 
    public float speed = 5f; 
    private float forwardInput;
    private GameObject focalPoint;  
    public bool hasPowerup;
    private float powerupStrength = 15.0f; 
    public GameObject powerupIndicator; 
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); 
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        powerupIndicator.transform.position = transform.position + new Vector3(0,-0.5f, 0);
    }
    private void FixedUpdate()
    {
         playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput); 
         if (transform.position.y < -10)
        {
            Destroy(gameObject); 
            gameOver = true; 
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine()); 
            powerupIndicator.gameObject.SetActive(true); 
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false; 
        powerupIndicator.gameObject.SetActive(false); 

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Debug.Log("player collided with" + collision.gameObject.name + "with powerup set to" + hasPowerup); 
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>(); 

            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position).normalized;
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse); 
        }
    }
    
}
