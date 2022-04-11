/*
* Joshua Patino
* Assignment 7 Prototype 4
* manages the spawn
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int enemyCount; 
    private UIManager UIManager; 
    public GameObject powerupPrefab; 
    public GameObject enemyPrefab; 
    public int waveNumber = 1; 
    private float spawnRange = 9; 
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        spawnPowerup(1);
       
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
         for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
     private void spawnPowerup(int powerupsToSpawn)
    {
         for (int i = 0; i < powerupsToSpawn; i++)
        {
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition() 
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosY = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosY); 
        return randomPos; 
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (enemyCount == 0)
        {
            waveNumber++; 
            UIManager.wave++; 
            SpawnEnemyWave(waveNumber); 
            spawnPowerup(1);
        }
    }
}
