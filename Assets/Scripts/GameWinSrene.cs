using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinSrene : MonoBehaviour
{
    public GameObject gameWinScreen;
    void RestartLevel()
    {
        if(gameWinScreen.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        }
    }

    void Update()
    {
        RestartLevel();
    }
}
