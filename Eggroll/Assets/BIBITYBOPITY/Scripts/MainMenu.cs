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
    }

    public void StartGame()
    {
        SceneManager.LoadScene(3);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OptionsMenu()
    {
        SceneManager.LoadScene(2);
    }
}
