/*
* Joshua Patino
* Assignment 7 Prototype 4
* controls the enemy AI
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Rigidbody enemyRb;
    public GameObject player; 
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>(); 
        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized; 
        //add force
        enemyRb.AddForce(lookDirection * speed); 

        if (transform.position.y < -10)
        {
            Destroy(gameObject); 
        }
    }
}
