using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseUILay;
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
