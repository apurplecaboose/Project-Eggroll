using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.Audio;

public class LvTimer : MonoBehaviour
{
    public ItemNumber ItNum;
    public TMP_Text TimerTextFeild;
    public float Startingtime;
    public float CurrentTime;
    private int LvNum;
    public GameObject UIdeath;

    public AudioSource source;


    void Start()
    {
        StopAllCoroutines();
        UIdeath.SetActive(false);
        LvNum = SceneManager.GetActiveScene().buildIndex;
        switch(LvNum)
        {
            case 4:
                Startingtime = ItNum.Lv1Time;
                break;
            case 5:
                Startingtime = ItNum.Lv2Time;
                break;
            case 6:
                Startingtime = ItNum.Lv3Time;
                break;
        }
        
        CurrentTime = Startingtime * 60f;
    }

    void Update()
    {
        CurrentTime -= 1f * Time.deltaTime;
        
        if (CurrentTime >= 0)
        {
            TimeSpan time = TimeSpan.FromSeconds(CurrentTime);
            TimerTextFeild.SetText(time.Minutes.ToString() + ":" + time.Seconds.ToString("00"));
        }
        else
        {
            StartCoroutine(PhatL());
        }

    }
    IEnumerator PhatL()
    {
        //display DED UI Element
        source.Stop();
        UIdeath.SetActive(true);
        yield return new WaitForSeconds(6.5f);
        SceneManager.LoadScene(LvNum);
    }
}
