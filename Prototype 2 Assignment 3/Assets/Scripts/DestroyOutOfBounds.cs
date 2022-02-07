/*
*Josh Patino
*Assignment 3, Prototype 2 
* destroy out of bound objects
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBound = 20; 
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //if food goes out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject); 
        }

        if (transform.position.z < bottomBound)
        {
            //Debug.Log("Game Over");
            //grab health system script and call take damage method
            healthSystemScript.TakeDamage(); 

            Destroy(gameObject);
        }
    }
}
