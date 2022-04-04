using System.Threading;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class GameManager : Singleton<GameManager>
{
    public int score; 

    public GameObject pauseMenu;  
    private string CurrentLevelName = string.Empty; 




    public void LoadLevel(string LevelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(LevelName, LoadSceneMode.Additive); 

        if (ao == null)
        {
            Debug.Log("Gamemanager unable to load level"); 
            return; 
        }
        this.CurrentLevelName = LevelName; 
    }

     public void UnloadLevel(string LevelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(LevelName); 

        if (ao == null)
        {
            Debug.Log("Gamemanager unable to unload level"); 
            return; 
        }
       
    }

    //paiuse and unpause 

    public void Pause() 
    {
        Time.timeScale = 0f; 
        pauseMenu.SetActive(true);
    }
    public void Unpause() 
    {
        Time.timeScale = 1f; 
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause(); 
        }
    }

    public void UnloadCurrentLevel()
    {
          AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName); 

        if (ao == null)
        {
            Debug.Log("Gamemanager unable to unload level"); 
            return; 
        }
    }
}
