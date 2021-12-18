using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class LevelSounds : MonoBehaviour
{
    public AudioSource Source;
    
    public AudioClip Swap;



    void Start()
    {
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            Source.PlayOneShot(Swap);
        }
    }
}
