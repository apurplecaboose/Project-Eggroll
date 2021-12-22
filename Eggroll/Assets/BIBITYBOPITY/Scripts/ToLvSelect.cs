using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLvSelect : MonoBehaviour
{
    public Coroutine ReeCache;
    public LevelContainer LvCont;
    public ItemNumber BIGGESTREEEEEEEEEEEEEEEE;

    private void Awake()
    {
        if (LvCont.Level1Cleared & LvCont.Level2Cleared & LvCont.Level3Cleared)
        {
            LvCont.AllLevelsCleared = true;
        }
    }
    void Update()
    {
     if(LvCont.AllLevelsCleared)
        {
            StartCoroutine(ToCredits());
        }


     if (Input.GetKeyDown(KeyCode.Space))
        {
            if(ReeCache != null)
            {
                StopCoroutine(ReeCache);
            }
            ReeCache = StartCoroutine(BacktoLvSelect());
        }
    }

    IEnumerator BacktoLvSelect()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(3);
    }


    IEnumerator ToCredits()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(10);
    }

}
