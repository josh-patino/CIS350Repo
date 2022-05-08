/*
* Joshua Patino
* Assignment 8 Prototype 5
* responlsible for the targes in the game, deleting them too
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
   
    public ParticleSystem explosionParticle; 
    public int pointValue; 
    private Rigidbody targetRb; 
    private float minSpeed = 12; 
    private float maxTorque = 10;
    private float ySpawnPos = -6; 
    private float maxSpeed = 16; 
    private float xRange = 4; 
    private GameManager gameManager; 
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>(); 
        
        //add force * speed
        targetRb.AddForce(RandomForce(), ForceMode.Impulse); 
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse); 
        transform.position = RandomSpawnPos(); 
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>(); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 RandomForce(){ return Vector3.up * Random.Range(minSpeed, maxSpeed); }
    private float RandomTorque(){return Random.Range(-maxTorque, maxTorque);}
    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange),ySpawnPos);
        
    }

    void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            gameManager.UpdateScore(pointValue); 
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation); 
            Destroy(gameObject); 
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver(); 
        }
        Destroy(gameObject); 
    }

    
}
