using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DevUI : MonoBehaviour
{
    public PlayerStats PlayerStats;
    public TMP_InputField StartingmoveSpeed;
    public TMP_InputField Startingrbdrag;

    public void MoveEdit(string msValue)
    {
        PlayerStats.moveSpeed = float.Parse(msValue);
    }
    public void Drag1Edit(string Drag1Val)
    {
        PlayerStats.drag = float.Parse(Drag1Val);
    }


    private void Start()
    {
        StartingmoveSpeed.text = PlayerStats.moveSpeed.ToString("0.0");
        Startingrbdrag.text = PlayerStats.drag.ToString("0.0");
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        { 
            Application.Quit(); 
        }
    }
}

