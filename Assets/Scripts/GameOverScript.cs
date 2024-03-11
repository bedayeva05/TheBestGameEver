using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{
    private PlayerHealth playerHealth; 
    public GameObject gameOverScreen;
    void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
        Time.timeScale = 1.0f;
    }

    
    void Update()
    {
        GameOverScreenActivation();
        RestartLevel();
    }

    void GameOverScreenActivation()
    {
        if (playerHealth.value <= 0)
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    void RestartLevel()
    {
        if(gameOverScreen.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        }
    }
}
