using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Difficuilty : MonoBehaviour
{
    public  TMP_Text textcont;
    public ItemNumber ItemNumber;


    void Start()
    {
        if (ItemNumber.Normal)
        {
            textcont.SetText("Normal");
            ItemNumber.Normal = true;
            ItemNumber.Hard = false;


            ItemNumber.Lv1Time = 4f;
            ItemNumber.Lv2Time = 4f;
            ItemNumber.Lv3Time = 5f;

        }
        else if (ItemNumber.Hard)
        {
            textcont.SetText("Hard");
            ItemNumber.Hard = true;
            ItemNumber.Normal = false;

            ItemNumber.Lv1Time = 0.8f;
            ItemNumber.Lv2Time = 0.8f;
            ItemNumber.Lv3Time = 0.8f;
        }
    }
    public void ClickedDifficulty()
    {
        FindObjectOfType<AudioManager>().Play("SettingsSfx");
        if (ItemNumber.Normal)
        {

            textcont.SetText("Hard");
            ItemNumber.Hard = true;
            ItemNumber.Normal = false;


            ItemNumber.Lv1Time = 0.8f;
            ItemNumber.Lv2Time = 0.8f;
            ItemNumber.Lv3Time = 0.8f;
        }
       else if (ItemNumber.Hard)
        {
            textcont.SetText("Normal");
            ItemNumber.Normal = true;
            ItemNumber.Hard = false;


            ItemNumber.Lv1Time = 4f;
            ItemNumber.Lv2Time = 4f;
            ItemNumber.Lv3Time = 5f;

        }
    }





}
