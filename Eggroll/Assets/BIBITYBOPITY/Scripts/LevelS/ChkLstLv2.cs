using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChkLstLv2 : MonoBehaviour
{
    public AudioSource source;
    public AudioSource source1;

    int CurrentNum = 1;

    public TMP_Text TextfieldTMP;
    public ItemNumber ItNum;
    void Start()
    {
        TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab pot<br>-Grab bag of Rice<br>-Wash Rice");
    }
    void JuciyFeedback()
    {
        if (CurrentNum == ItNum.ItemNumberInt)
        {
            source.PlayOneShot(source.clip);
            source1.PlayOneShot(source1.clip);
            CurrentNum += 1;
        }
    }

    void Update()
    {
        switch (ItNum.ItemNumberInt)
        {
            case 1:
                TextfieldTMP.SetText("<u>Instructions:</u><color=#E80262><s><br>-Grab pot<br></s></color>-Grab bag of Rice<br>-Wash Rice");
                JuciyFeedback();
                break;
            case 2:
                TextfieldTMP.SetText("<u>Instructions:</u><color=#E80262><s><br>-Grab pot<br>-Grab bag of Rice</color></s><br>-Wash Rice");
                JuciyFeedback();
                break;
            case 3:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Set on Stove<br>-Grab Raw Meat<br>-Grab Red Pepper");
                JuciyFeedback();
                break;
            case 4:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Set on Stove<br></s></color>-Grab Raw Meat<br>-Grab Red Pepper");
                JuciyFeedback();
                break;
            case 5:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Set on Stove<br>-Grab Raw Meat<br></s></color>-Grab Red Pepper");
                JuciyFeedback();
                break;
            case 6:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab Green Onions<br>-Grab Carrot<br>-Grab Mushroom");
                JuciyFeedback();
                break;
            case 7:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab Green Onions</s></color><br>-Grab Carrot<br>-Grab Mushroom");
                JuciyFeedback();
                break;
            case 8:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab Green Onions<br>-Grab Carrot<br></s></color>-Grab Mushroom");
                JuciyFeedback();
                break;
            case 9:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab Eggs<br>-Grab Knife<br>-Cut Food");
                JuciyFeedback();
                break;
            case 10:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab Eggs</s></color><br>-Grab Knife<br>-Cut Food");
                JuciyFeedback();
                break;
            case 11:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab Eggs<br>-Grab Knife</s></color><br>-Cut Food");
                JuciyFeedback();
                break;
            case 12:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab pans<br>-Put pans on stove<br>-Cook Meat");
                JuciyFeedback();
                break;
            case 13:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab pans<br></s></color>-Put pans on stove<br>-Cook Meat");
                JuciyFeedback();
                break;
            case 14:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab pans<br>-Put pans on stove<br></s></color>-Cook Meat");
                JuciyFeedback();
                break;
            case 15:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Cook Egg<br>-Grab Bowl<br>-Assemble Bowl");
                JuciyFeedback();
                break;
            case 16:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Cook Egg</s></color><br>-Grab Bowl<br>-Assemble Bowl");
                JuciyFeedback();
                break;
            case 17:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Cook Egg<br>-Grab Bowl</s></color><br>-Assemble Bowl");
                JuciyFeedback();
                break;
            case 18:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Cook Egg<br>-Grab Bowl<br>-Assemble Bowl</s></color>");
                JuciyFeedback();
                break;
        }
    }
}
