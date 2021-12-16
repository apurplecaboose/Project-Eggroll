using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLvSelect : MonoBehaviour
{
    public Coroutine ReeCache;
    public LevelContainer LvCont;

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
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(10);
    }

}
