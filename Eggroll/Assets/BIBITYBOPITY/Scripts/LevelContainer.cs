using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "LevelContainer")]
public class LevelContainer : ScriptableObject
{
    public int PlayerLevel = 1;
    public bool AllLevelsCleared = false;

    public bool Level1Cleared = false;
    public bool Level2Cleared = false;
    public bool Level3Cleared = false;
}
