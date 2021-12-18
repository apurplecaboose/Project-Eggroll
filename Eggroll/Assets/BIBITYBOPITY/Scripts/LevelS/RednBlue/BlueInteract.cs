using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueInteract : MonoBehaviour
{
    public GameObject BlueBeepUI;
    //
    public GameObject RedBeepUI;
    
    private void Awake()
    {
        //BlueBeepUI = GameObject.Find("BlueUI");
        BlueBeepUI.SetActive(false);
//
        //RedBeepUI = GameObject.Find("RedUI");
        RedBeepUI.SetActive(false);
    }
    

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BlueBeepUI.SetActive(false);
        }
        BlueBeepUI.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        BlueBeepUI.SetActive(false);
    }
}
