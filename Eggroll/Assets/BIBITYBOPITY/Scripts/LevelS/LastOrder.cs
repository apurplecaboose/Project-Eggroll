using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastOrder : MonoBehaviour
{
    private bool entered = false;
    public ItemNumber ItemNumber;
    public GameObject FoodHere;
    public GameObject OrderofOperations;
    public GameObject Uinteract;

    private void Update()
    {
        ClickRegistration();
    }

    private void ClickRegistration()
    {
        if (entered)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (FoodHere.activeSelf)
                {
                    FoodHere.SetActive(false);
                }
                else
                {
                    FoodHere.SetActive(true);
                }
                Uinteract.SetActive(false);
                ItemNumber.ItemNumberInt += 1;
                OrderofOperations.SetActive(false);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Uinteract.SetActive(true);
        entered = true;
    }
    private void OnTriggerExit(Collider other)
    {
        Uinteract.SetActive(false);
    }
}
