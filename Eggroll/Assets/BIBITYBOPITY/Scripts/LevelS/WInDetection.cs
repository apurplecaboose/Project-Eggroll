using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WInDetection : MonoBehaviour
{
    public ItemNumber ItmNum;
    public int CurrentLvlNumb;
    public LevelContainer LvCont;

    void Start()
    {
        CurrentLvlNumb = SceneManager.GetActiveScene().buildIndex;
        if(LvCont.Level1Cleared & LvCont.Level2Cleared & LvCont.Level3Cleared)
        {
            LvCont.AllLevelsCleared = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (CurrentLvlNumb)
        {
            case 4:
                if (ItmNum.ItemNumberInt == ItmNum.TargetNumLv1)
                {
                    LvCont.Level1Cleared = true;
                    StartCoroutine(WLv1());
                    
                }
                break;
            case 5:
                if (ItmNum.ItemNumberInt == ItmNum.TargetNumLv2)
                {
                    LvCont.Level2Cleared = true;
                    StartCoroutine(WLv2());
                }
                break;
            case 6:
                if (ItmNum.ItemNumberInt == ItmNum.TargetNumLv3)
                {
                    LvCont.Level3Cleared = true;
                    StartCoroutine(WLv3());
                }
                break;
        } 
    }

    IEnumerator WLv1()
    { 
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(7);
    }
    IEnumerator WLv2()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(8);
    }
    IEnumerator WLv3()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(9);
    }

}
