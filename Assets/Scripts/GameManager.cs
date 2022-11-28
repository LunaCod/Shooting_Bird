using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PausGameMenu;

    public bool checkPause = false;
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
        checkPause = false;
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
        checkPause = false;
    }
    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        checkPause = false;
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        PausGameMenu.SetActive(true);
        checkPause = true;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        PausGameMenu.SetActive(false);
        checkPause = false;
    }

}
