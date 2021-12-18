using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Audio;
public class LevelSelect : MonoBehaviour
{
    public AudioSource source;

    private int SceneNumber = 0;

    public void LoadLevelOne()
    {
        source.PlayOneShot(source.clip);
        SceneNumber = 4;
        StartCoroutine(LoadingScene());
    }
    public void LoadLevelTwo()
    {
        source.PlayOneShot(source.clip);
        SceneNumber = 5;
        StartCoroutine(LoadingScene());
    }
    public void LoadLevelThree()
    {
        source.PlayOneShot(source.clip);
        SceneNumber = 6;
        StartCoroutine(LoadingScene());
    }
    public void LoadMainMenu()
    {
        FindObjectOfType<AudioManager>().Play("SettingsSfx");
        SceneManager.LoadScene(1);
    }

    IEnumerator LoadingScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneNumber);
    }
}
