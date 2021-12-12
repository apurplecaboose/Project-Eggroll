using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapScript : MonoBehaviour
{
    public Animator ani;
    public GameObject Sprite1;
    public GameObject SPrite2;
    public bool Swapped = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (Swapped) Swapped = false;
            else Swapped = true;
        }

        if (Swapped)
        {
            Sprite1.SetActive(false);
            SPrite2.SetActive(true);
            ani.SetBool("SwappedAni", true);
        }
        else
        {
            Sprite1.SetActive(true);
            SPrite2.SetActive(false);
            ani.SetBool("SwappedAni", false);
        }
    }
}
