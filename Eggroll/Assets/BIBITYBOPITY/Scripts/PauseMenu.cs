using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseUILay;
    public LevelContainer LevelContainer;
    public Coroutine REEEE;
    public static bool GameisPaused = false;
    
    private void Start()
    {
        Time.timeScale = 1f;
        CurrentLevelChecker();
        Cursor.lockState = CursorLockMode.Confined;
    }
    void CurrentLevelChecker()
    {
        if ((LevelContainer.PlayerLevel != SceneManager.GetActiveScene().buildIndex) & (LevelContainer.PlayerLevel < SceneManager.GetActiveScene().buildIndex))
        {
            LevelContainer.PlayerLevel = SceneManager.GetActiveScene().buildIndex;
            LevelStateStorage();
        }
    }
    private void Update()
    {
     if (Input.GetKeyDown(KeyCode.Escape) | Input.GetKeyDown(KeyCode.P))
        {
            if (REEEE != null)
            {
                StopCoroutine(REEEE);
            }
            REEEE = StartCoroutine(DumbPause());
        }
    }
    IEnumerator DumbPause()
    {
        if (GameisPaused) ResumeGame();
        else PauseGame();
        yield return true;
    }
    public void LevelStateStorage()
    {
        switch (LevelContainer.PlayerLevel)
        {
            case 5:
                LevelContainer.Level2Unlocked = true;
                break;
            case 6:
                LevelContainer.Level2Unlocked = true;
                LevelContainer.Level3Unlocked = true;
                break;
            case 7:
                LevelContainer.Level2Unlocked = true;
                LevelContainer.Level3Unlocked = true;
                LevelContainer.AllLevelsCleared = true;
                break;
        }
    }
    public void ResumeGame()
    {
        PauseUILay.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }
    public void PauseGame()
    {
        PauseUILay.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }
    public void QuitGame()
    {
        CurrentLevelChecker();
        //add saving functions
        Application.Quit();
    }
    public void OptionsMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
