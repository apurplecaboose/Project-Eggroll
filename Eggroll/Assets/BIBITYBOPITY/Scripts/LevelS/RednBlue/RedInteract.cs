using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedInteract : MonoBehaviour
{
    public GameObject RedBeepUI;
    //
    public GameObject BlueBeepUI;
    
    private void Awake()
    {
        //RedBeepUI = GameObject.Find("RedUI");
        RedBeepUI.SetActive(false);
        //
        //BlueBeepUI = GameObject.Find("BlueUI");
        BlueBeepUI.SetActive(false);
    }
    

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RedBeepUI.SetActive(false);
        }
        RedBeepUI.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        RedBeepUI.SetActive(false);
    }
}
