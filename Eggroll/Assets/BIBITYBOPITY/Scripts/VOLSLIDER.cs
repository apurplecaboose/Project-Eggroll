using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class VOLSLIDER : MonoBehaviour
{
    public AudioMixer blender;

    public void SliderVolume(float globalvolume)
    {
        blender.SetFloat("MasterSlider", globalvolume);
    }
    public void BackButton()
    {
        SceneManager.LoadScene(1);
    }
}
