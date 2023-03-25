using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    #region Singleton
    public static GameManager instance;

    private void Awake()
    {
        gameOverCanvas.SetActive(false);

        if (instance == null)
        {
            instance = this;
        }

        Time.timeScale = 1;
    }
    #endregion

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}