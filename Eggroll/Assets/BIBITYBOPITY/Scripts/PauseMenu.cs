using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseUILay;
    public LevelContainer LevelContainer;
    public Coroutine REEEE;
    bool GameisPaused = false;

    public AudioMixer blender;
    private void Start()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) | Input.GetKeyDown(KeyCode.P))
        {
            if (GameisPaused) ResumeGame();
            else PauseGame();

            /*
            if (REEEE != null)
            {
                StopCoroutine(REEEE);
            }
            REEEE = StartCoroutine(DumbPause());\
            */
        }
    }
    IEnumerator DumbPause()
    {
        if (GameisPaused) ResumeGame();
        else PauseGame();
        yield return true;
    }
    public void SliderVolume(float globalvolume)
    {
        blender.SetFloat("MasterSlider", globalvolume);
    }
    public void ResumeGame()
    {
        PauseUILay.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Confined;
        GameisPaused = false;
        Debug.Log("Resuming");
    }
    public void PauseGame()
    {
        PauseUILay.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        GameisPaused = true;
    }
    public void QuitGame()
    {
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
