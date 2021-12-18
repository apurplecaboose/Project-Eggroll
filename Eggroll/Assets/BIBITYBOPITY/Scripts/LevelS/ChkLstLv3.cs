using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChkLstLv3 : MonoBehaviour
{
    public AudioSource source;
    public AudioSource source1;

    int CurrentNum = 1;

    public TMP_Text TextfieldTMP;
    public ItemNumber ItNum;
    void Start()
    {
        TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab eggroll wrappers<br>-Wet wrappers<br>-Place wrappers on plate");
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
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab eggroll wrappers<br></s></color>-Wet wrappers<br>-Place wrappers on plate");
                JuciyFeedback();
                break;
            case 2:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab eggroll wrappers<br>-Wet wrappers</s></color><br>-Place wrappers on plate");
                JuciyFeedback();
                break;
            case 3:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab Carrots<br>-Grab Onions<br>-Grab Cabbage");
                JuciyFeedback();
                break;
            case 4:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab Carrots<br></s></color>-Grab Onions<br>-Grab Cabbage");
                JuciyFeedback();
                break;
            case 5:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab Carrots<br>-Grab Onions<br></s></color>-Grab Cabbage");
                JuciyFeedback();
                break;
            case 6:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab Knife<br>-Cut Veggies<br>-Grab Cut Veggies");
                JuciyFeedback();
                break;
            case 7:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s><color=#E80262>-Grab Knife</s></color><br>-Cut Veggies<br>-Grab Cut Veggies");
                JuciyFeedback();
                break;
            case 8:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s><color=#E80262>-Grab Knife<br>-Cut Veggies</s></color><br>-Grab Cut Veggies");
                JuciyFeedback();
                break;
            case 9:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab Meat<br>-Grab Meat Tenderizer(Hammer)<br>-Tenderize Meat");
                JuciyFeedback();
                break;
            case 10:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s><color=#E80262>-Grab Meat<br></s></color>-Grab Meat Tenderizer(Hammer)<br>-Tenderize Meat");
                JuciyFeedback();
                break;
            case 11:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s><color=#E80262>-Grab Meat<br>-Grab Meat Tenderizer(Hammer)</s></color><br>-Tenderize Meat");
                JuciyFeedback();
                break;
            case 12:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab Tenderized Meat<br>-Grab Pan<br>-Put Pan on Stove");
                JuciyFeedback();
                break;
            case 13:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab Tenderized Meat</s></color><br>-Grab Pan<br>-Put Pan on Stove");
                JuciyFeedback();
                break;
            case 14:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Grab Tenderized Meat<br>-Grab Pan</s></color><br>-Put Pan on Stove");
                JuciyFeedback();
                break;
            case 15:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Fry Veggies and Meat<br>-Grab Wrappers<br>-Wrap Veggies and Meat");
                JuciyFeedback();
                break;
            case 16:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s><color=#E80262>-Fry Veggies and Meat</s></color><br>-Grab Wrappers<br>-Wrap Veggies and Meat");
                JuciyFeedback();
                break;
            case 17:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s><color=#E80262>-Fry Veggies and Meat<br>-Grab Wrappers</s></color><br>-Wrap Veggies and Meat");
                JuciyFeedback();
                break;
            case 18:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Fry Again");
                JuciyFeedback();
                break;
            case 19:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Fry Again</s></color>");
                JuciyFeedback();
                break;
        }
    }
}
