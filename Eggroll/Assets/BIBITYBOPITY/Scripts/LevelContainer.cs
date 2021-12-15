using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "LevelContainer")]
public class LevelContainer : ScriptableObject
{
    public int PlayerLevel = 1;
    public bool Level2Unlocked = false;
    public bool Level3Unlocked = false;
    public bool AllLevelsCleared = false;
}
