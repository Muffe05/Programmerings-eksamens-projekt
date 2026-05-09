using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[CreateAssetMenu(fileName ="New Item")] //Makes this available in the Unity menu
public class ItemSO : ScriptableObject
{
    public string itemName;
    [TextArea] public string itemDescription;//makes a description for item and [TextArea] makes the box you write in bigger :)
    public Sprite icon;

    public bool isGold;

    [Header("Stats")]

    public int currentHealth;
    public int maxHealth;
    public int speed;
    public int damage;

    [Header("For Temp Items")]
    public float duration;
}
