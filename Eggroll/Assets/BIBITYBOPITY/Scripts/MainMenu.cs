using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 1;
    }

    public void StartGame()
    {
        FindObjectOfType<AudioManager>().Play("SettingsSfx");
        SceneManager.LoadScene(3);
    }
    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("SettingsSfx");
        Application.Quit();
    }
    public void OptionsMenu()
    {
        FindObjectOfType<AudioManager>().Play("SettingsSfx");
        SceneManager.LoadScene(2);
    }
    public void LoadCredits()
    {
        FindObjectOfType<AudioManager>().Play("SettingsSfx");
        SceneManager.LoadScene(10);
    }
}
