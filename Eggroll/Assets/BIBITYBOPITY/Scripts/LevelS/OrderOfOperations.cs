using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderOfOperations : MonoBehaviour
{
    public bool InCollider = false;
    public ItemNumber ItemNumber;
    public GameObject FoodHere;
    public GameObject NextCollider;
    public GameObject OrderofOperations;
    public GameObject Uinteract;

    private void Update()
    {
        ClickRegistration();
    }

    private void ClickRegistration()
    {
        if(InCollider)
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
                NextCollider.SetActive(true);
                Uinteract.SetActive(false);
                ItemNumber.ItemNumberInt += 1;
                OrderofOperations.SetActive(false);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Uinteract.SetActive(true);
        InCollider = true;
        
    }
    private void OnTriggerExit(Collider other)
    {
        Uinteract.SetActive(false);
        InCollider = false;
    }
}
