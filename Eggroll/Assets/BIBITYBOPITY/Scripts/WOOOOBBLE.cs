using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WOOOOBBLE : MonoBehaviour
{
    public Rigidbody rb1;
    public Rigidbody rb2;
    public ItemNumber ItemNumber;
    float multiplier;
    int randomInt;
    private int WhenWinterRollsAround = 0;//12
    Vector3[] VectorArray = { new Vector3(1, 0, 1), new Vector3(1, 0, 0), new Vector3(0, 0, 1), new Vector3(1, 0, 0), new Vector3(-1, 0, -1), new Vector3(0, 0, -1), new Vector3(-1, 0, 0), new Vector3(0, 0, -1)};

    void Start()
    {
        StartCoroutine(RandomForce());
        multiplier = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        randomInt = Random.Range(0, VectorArray.Length);

    }
    IEnumerator RandomForce()
    {
        while (true) 
        {
            if(WhenWinterRollsAround >= ItemNumber.ItemNumberInt)
            {
                yield return new WaitForSeconds(0.5f);
                rb1.AddForce(multiplier * VectorArray[randomInt], ForceMode.Impulse);
                rb2.AddForce(multiplier*VectorArray[randomInt], ForceMode.Impulse);
            }
        }
    }
}
