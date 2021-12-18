using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ItemNumber")]
public class ItemNumber : ScriptableObject
{
    public int ItemNumberInt = 0;
    public int TargetNumLv1 = 18;
    public int TargetNumLv2 = 10;
    public int TargetNumLv3 = 10;


    public float Lv1Time = 4f;
    public float Lv2Time = 4f;
    public float Lv3Time = 5f;
    
    public bool Normal = true;
    public bool Hard = false;
}