using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChkLstLv3 : MonoBehaviour
{
    public TMP_Text TextfieldTMP;
    public ItemNumber ItNum;
    void Start()
    {
        TextfieldTMP.SetText("<u>Instructions:</u><br>-RRRRRRRRRRRRRRRREEEEEEEEEEEEEEEEEEE");
    }

    void Update()
    {
        switch (ItNum.ItemNumberInt)
        {
            case 1:
                TextfieldTMP.SetText("<font color=red><u>Instructions:</u><br><s>-Grab Pot</s><br>-Grab Pot Lid<br>-Fill Pot with Water</red>");
                break;
            case 2:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s>-Grab Pot<br>-Grab Pot Lid</s><br>-Fill Pot with Water");
                break;
            case 3:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Boil water on Stove<br>-Find raw Meat<br>-Find Meat Tenderizer (Hammer)");
                break;
            case 4:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s>-Boil water on Stove</s><br>-Find raw Meat<br>-Find Meat Tenderizer (Hammer)");
                break;
            case 5:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s>-Boil water on Stove<br>-Find raw Meat</s><br>-Find Meat Tenderizer (Hammer)");
                break;
            case 6:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s>-Find raw Meat<br>-Find Meat Tenderizer (Hammer) </s><br>-Smash into Meatballs On cutting board");
                break;
            case 7:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab Uncooked Pasta<br>-Add uncooked pasta to the boiling water<br>-Find Tomatoes");
                break;
            case 8:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s>-Grab Uncooked Pasta</s><br>-Add uncooked pasta to the boiling water<br>-Find Tomatoes");
                break;
            case 9:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s>-Add uncooked pasta to the boiling water</s><br>-Find Tomatoes<br>-Find Bottle of Oil(glass)");
                break;
            case 10:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s>-Add uncooked pasta to the boiling water<br>-Find Tomatoes</s><br>-Find Bottle of Oil(glass)");
                break;
            case 11:
                TextfieldTMP.SetText("<u>Instructions:</u><s><br>-Find Bottle of Oil(glass)</s><br>-find frying pan<br>-Place frying pan on stove");
                break;
            case 12:
                TextfieldTMP.SetText("<u>Instructions:</u><s><br>-Find Bottle of Oil(glass)<br>-find frying pan</s><br>-Place frying pan on stove");
                break;
            case 13:
                TextfieldTMP.SetText("<u>Instructions:</u><br>-Grab pasta pot<br>-Strain pasta out in the sink<br>-Throw the pasta in the pan");
                break;
            case 14:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s>-Grab pasta pot</s><br>-Strain pasta out in the sink<br>-Throw the pasta in the pan");
                break;
            case 15:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s>-Strain pasta out in the sink</s><br>-Throw the pasta in the pan<br>-Find Cheese(Slices)");
                break;
            case 16:
                TextfieldTMP.SetText("<u>Instructions:</u><br><s>-Strain pasta out in the sink<br>-Throw the pasta in the pan</s><br>-Find Cheese(Slices)");
                break;
            case 17:
                TextfieldTMP.SetText("<u>Instructions:</u><s><br>-Throw the pasta in the pan<br>-Find Cheese(Slices)</s><br>-Add Cheese to pan");
                break;
            case 18:
                TextfieldTMP.SetText("<u>Instructions:</u><s><br>-Throw the pasta in the pan<br>-Find Cheese(Slices)<br>-Add Cheese to pan");
                break;
        }
    }
}
