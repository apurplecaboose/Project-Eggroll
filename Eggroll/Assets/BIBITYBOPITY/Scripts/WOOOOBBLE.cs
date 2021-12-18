using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WOOOOBBLE : MonoBehaviour
{
    public Rigidbody rb1;
    public Rigidbody rb2;
    public ItemNumber ItemNumber;
    bool CocoPuffs = true;
    float multiplier;
    float randomfloat;
    float randomfloat2;
    private int WhenWinterRollsAround = 12;
    

    void Start()
    {
        multiplier = 6.75f;
    }

    void Update()
    {
        randomfloat = Random.Range(-1f, 1f);
        randomfloat2 = Random.Range(-1f, 1f);
        if(ItemNumber.ItemNumberInt >= WhenWinterRollsAround)
        {
            if(CocoPuffs)
            {
                StartCoroutine(RandomForce());
                CocoPuffs = false;
            }
        }
    }
    IEnumerator RandomForce()
    {
        while (true) 
        {
            if(ItemNumber.ItemNumberInt >= WhenWinterRollsAround)
            {
                yield return new WaitForSeconds(0.25f);

                rb1.AddForce(new Vector3(randomfloat * multiplier, 0f, randomfloat2 * multiplier), ForceMode.Impulse);
                rb2.AddForce(new Vector3(randomfloat * multiplier, 0f, randomfloat2 * multiplier), ForceMode.Impulse);
            }
        }
    }
}
