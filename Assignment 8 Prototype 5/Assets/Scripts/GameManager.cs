using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
     public bool isGameActive; 
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText; 
    private int score; 

    private float spawnRate = 1.0f; 
    public List<GameObject> Targets; 
    public Button restartButton; 
    public GameObject titleScreen;

    public void StartGame(int difficulty)
    {
        spawnRate /= difficulty; 
        isGameActive = true; 
        StartCoroutine(SpawnTarget()); 
        score = 0; 
        UpdateScore(0); 
        titleScreen.gameObject.SetActive(false); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
       
        
    }
    
    public void ResartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd; 
        scoreText.text = "Score: " + score; 
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, Targets.Count); 
            Instantiate(Targets[index]); 

            //testing
            //UpdateScore(5); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true); 
        isGameActive = false; 
        restartButton.gameObject.SetActive(true); 
    }

}
