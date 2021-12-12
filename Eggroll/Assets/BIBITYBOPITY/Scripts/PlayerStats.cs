using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "PlayerStats")]
public class PlayerStats : ScriptableObject
{
    public float moveSpeed = 10f;
    public float speedMultiplier = 10f;
    public float SideSpeed = 0.5f;
    public float drag = 2f;
    public float jumpforce = 30f;
    public float Grav = 2f;
}

