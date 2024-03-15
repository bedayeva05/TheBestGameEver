using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinScreenPlayer : MonoBehaviour
{
    public static int killedEnemy;
    public int killToWin;
    public GameObject winScreen;
    void Start()
    {
        Time.timeScale = 1.0f;
        killedEnemy = 0;
    }
    void Update()
    {
        if(killedEnemy == killToWin) 
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f;
        }
        RestartLevel();
    }
     void RestartLevel()
    {
        if(winScreen.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        }
    }
}
