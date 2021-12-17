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
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=red><s>-Grab Pot</s></color><br>-Grab bag of Rice<br>-Wash Rice");
                break;
            case 2:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=red><s>-Grab Pot<br>-Grab bag of Rice</s></color><br>-Wash Rice");
                break;
            case 3:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=red><s>-Grab bag of Rice<br>-Wash Rice</s></color><br>Set pot of rice on stove");
                break;
            case 4:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab raw meat <br>-Grab Red Peppers<br>-Grab Green Onions");
                break;
            case 5:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=red><s>-Grab raw meat</s></color><br>-Grab Red Peppers<br>-Grab Green Onions");
                break;
            case 6:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=red><s>-Grab Red Peppers</s></color><br>-Grab Green Onions<br>-Grab Carrots");
                break;
            case 7:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=red><s>-Grab Green Onions</s></color><br>-Grab Carrots<br>-Grab Mushrooms");
                break;
            case 8:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=red><s>-Grab Carrots</s></color><br>-Grab Mushrooms<br>-Grab Eggs");
                break;
            case 9:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=red><s>-Grab Carrots<br>-Grab Mushrooms</s></color><br>-Grab Eggs");
                break;
            case 10:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab a knife<br>-Cut the food<br>-Grab the frying pans");

                break;
            case 11:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=red><s>-Grab a knife</s></color><br>-Cut the food<br>-Grab the frying pans");
                
                break;
            case 12:
                
                break;
            case 13:
                
                break;
            case 14:
                
                break;
            case 15:
                
                break;
            case 16:
                
                break;
            case 17:
                
                break;
            case 18:
                
                break;
        }
    }
}
