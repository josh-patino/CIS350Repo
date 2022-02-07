/*
*Josh Patino
*Assignment 3, Prototype 2 
* managaes the spawn system for the prototype
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//stopped at 1:27:23
public class SpawnManager : MonoBehaviour
{
   //set this array of references in the inspector
   public GameObject[] prefabsToSpawn;

    // variables for spawn positions
    private float leftBound = -14; 
    private float rightbound = 14; 
    private float spawnPosZ = 20;  

    public HealthSystem healthSystem; 

    void Start()
    {
        //get a ref to hralth system script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>(); 
        StartCoroutine(SpawnRandomPrefabWtihCoroutine());         
    }

    IEnumerator SpawnRandomPrefabWtihCoroutine()
    {
        //add a 3 second delay before first spawning object
        yield return new WaitForSeconds(3f);
        while (!healthSystem.gameOver)
        {
            SpawnRandomPreFab();

            float randomDelay = Random.Range(0.8f, 2.0f); 

            yield return new WaitForSeconds(randomDelay);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //SpawnRandomPreFab(); 
        }
    }

    void SpawnRandomPreFab()
    {
        //pick a random animal
            int prefabIndex = Random.Range(0,prefabsToSpawn.Length);

            // generate random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(leftBound,rightbound), 0, spawnPosZ);

            // random animal to spawn
            Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
