using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnNext = 1.0f;
    bool spawnDog = true;

    // Update is called once per frame
    void Update()
    {
        // check if spawnDog is true ,On spacebar press, send dog
        if (spawnDog && Input.GetKeyDown(KeyCode.Space))
        {
            //spawn dog and set bool to false, start coroutine that contains a timer refering to var spawnNext
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawnDog = false;
            StartCoroutine("spawnDogTimer"); 
        }

    }
    //
    IEnumerator spawnDogTimer()
    {   //after x time set bool true to spawn dog again this will give a delay of 2 secs by default or more / less if set
        yield return new WaitForSeconds(spawnNext); //this may be slightly inconsistant but works
        spawnDog = true;
    }


}