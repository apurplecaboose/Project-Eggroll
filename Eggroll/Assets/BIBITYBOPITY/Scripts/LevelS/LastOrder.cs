using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastOrder : MonoBehaviour
{
    private bool entered = false;
    public ItemNumber ItemNumber;
    public GameObject FoodHere;
    public GameObject OrderofOperations;

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
                ItemNumber.ItemNumberInt += 1;
                OrderofOperations.SetActive(false);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //Enable Interact UI
        Debug.Log("entered");
        entered = true;

    }
    private void OnTriggerExit(Collider other)
    {
        //Disable Interact UI
    }
}
