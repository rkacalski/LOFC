using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Vehicle")]
public class vehicle : ScriptableObject
{
    public string vehicleName;
    public string displayName;
    public Sprite art;
    public int rarity;
    public string range;
    public string atkPatern;
    public int atkFreq;
    public int attack;
    public int defense;
    public int accuracy;
    public int evasion;
    public int cost;
    public double attack_mult;
    public double defense_mult;
    public int level;
    public int HP;
    public bool inForm;
    public string vehicleDescript;
    public int X;
    public int Y;
    public string numPiolts;
    public string numCoPiolts;
    public int numParts;
}
