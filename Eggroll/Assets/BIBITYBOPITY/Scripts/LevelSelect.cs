using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(5);
    }
    public void LoadLevelThree()
    {
        SceneManager.LoadScene(6);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
