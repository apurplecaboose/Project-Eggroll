using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChkLstLv2 : MonoBehaviour
{
    public TMP_Text TextfieldTMP;
    public ItemNumber ItNum;
    void Start()
    {
        TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab pot<br>-Grab bag of Rice<br>-Wash Rice");
    }

    void Update()
    {
        switch (ItNum.ItemNumberInt)
        {
            case 1:
                TextfieldTMP.SetText("<u>Instructions:</u><color=red><s><br>-Grab pot<br></s></color>-Grab bag of Rice<br>-Wash Rice");
                break;
            case 2:
                TextfieldTMP.SetText("<u>Instructions:</u><color=red><s><br>-Grab pot<br>-Grab bag of Rice</color></s><br>-Wash Rice");
                break;
            case 3:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Set on Stove<br>-Grab Raw Meat<br>-Grab Red Pepper");
                break;
            case 4:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=red><br>-Set on Stove<br></s></color>-Grab Raw Meat<br>-Grab Red Pepper");
                break;
            case 5:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=red><br>-Set on Stove<br>-Grab Raw Meat<br></s></color>-Grab Red Pepper");
                break;
            case 6:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab Green Onions<br>-Grab Carrot<br>-Grab Mushroom");
                break;
            case 7:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=red><br>-Grab Green Onions</s></color><br>-Grab Carrot<br>-Grab Mushroom");
                break;
            case 8:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=red><br>-Grab Green Onions<br>-Grab Carrot<br></s></color>-Grab Mushroom");
                break;
            case 9:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab Eggs<br>-Grab Knife<br>-Cut Food");
                break;
            case 10:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=red><br>-Grab Eggs</s></color><br>-Grab Knife<br>-Cut Food");
                break;
            case 11:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=red><br>-Grab Eggs<br>-Grab Knife</s></color><br>-Cut Food");
                break;
            case 12:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab pans<br>-Put pans on stove<br>-Cook Meat");
                break;
            case 13:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=red><br>-Grab pans<br></s></color>-Put pans on stove<br>-Cook Meat");
                break;
            case 14:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=red><br>-Grab pans<br>-Put pans on stove<br></s></color>-Cook Meat");
                break;
            case 15:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Cook Egg<br>-Grab Bowl<br>-Assemble Bowl");
                break;
            case 16:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=red><br>-Cook Egg</s></color><br>-Grab Bowl<br>-Assemble Bowl");
                break;
            case 17:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=red><br>-Cook Egg<br>-Grab Bowl</s></color><br>-Assemble Bowl");
                break;
            case 18:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=red><br>-Cook Egg<br>-Grab Bowl<br>-Assemble Bowl</s></color>");
                break;
        }
    }
}
