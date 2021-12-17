using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChkLstLv1 : MonoBehaviour
{
    public TMP_Text TextfieldTMP;
    public ItemNumber ItNum;
    void Start()
    {
        TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab Pot<br>-Grab Pot Lid<br>-Fill Pot with Water");
    }

    void Update()
    {
       switch (ItNum.ItemNumberInt)
        {
            case 1:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=#E80262><s>-Grab Pot</s></color><br>-Grab Pot Lid<br>-Fill Pot with Water");
                break;
            case 2:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=#E80262><s>-Grab Pot<br>-Grab Pot Lid</s></color><br>-Fill Pot with Water");
                break;
            case 3:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Boil water on Stove<br>-Find raw Meat<br>-Find Meat Tenderizer (Hammer)");
                break;
            case 4:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s><color=#E80262>-Boil water on Stove</s></color><br>-Find raw Meat<br>-Find Meat Tenderizer (Hammer)");
                break;
            case 5:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s><color=#E80262>-Boil water on Stove<br>-Find raw Meat</s></color><br>-Find Meat Tenderizer (Hammer)");
                break;
            case 6:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s><color=#E80262>-Find raw Meat<br>-Find Meat Tenderizer (Hammer) </s></color><br>-Smash into Meatballs On cutting board");
                break;
            case 7:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab Uncooked Pasta<br>-Add uncooked pasta to the boiling water<br>-Find Tomatoes");
                break;
            case 8:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=#E80262><s>-Grab Uncooked Pasta</s></color><br>-Add uncooked pasta to the boiling water<br>-Find Tomatoes");
                break;
            case 9:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=#E80262><s>-Add uncooked pasta to the boiling water</s></color><br>-Find Tomatoes<br>-Find Bottle of Oil(glass)");
                break;
            case 10:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s><color=#E80262>-Add uncooked pasta to the boiling water<br>-Find Tomatoes</s></color><br>-Find Bottle of Oil(glass)");
                break;
            case 11:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Find Bottle of Oil(glass)</s><br></color>-find frying pan<br>-Place frying pan on stove");
                break;
            case 12:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Find Bottle of Oil(glass)<br>-find frying pan</s></color><br>-Place frying pan on stove");
                break;
            case 13:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab pasta pot<br>-Strain pasta out in the sink<br>-Throw the pasta in the pan");
                break;
            case 14:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=#E80262><s>-Grab pasta pot</s></color><br>-Strain pasta out in the sink<br>-Throw the pasta in the pan");
                break;
            case 15:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=#E80262><s>-Strain pasta out in the sink</s></color><br>-Throw the pasta in the pan<br>-Find Cheese(Slices)");
                break;
            case 16:
                TextfieldTMP.SetText("<u>Instructions:</u><br><color=#E80262><s>-Strain pasta out in the sink<br>-Throw the pasta in the pan</s></color><br>-Find Cheese(Slices)");
                break;
            case 17:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Throw the pasta in the pan<br>-Find Cheese(Slices)</s></color><br>-Add Cheese to pan");
                break;
            case 18:
                TextfieldTMP.SetText("<u>Instructions:</u><s><color=#E80262><br>-Throw the pasta in the pan<br>-Find Cheese(Slices)<br>-Add Cheese to pan</s></color>");
                break;
        }
    }
}
