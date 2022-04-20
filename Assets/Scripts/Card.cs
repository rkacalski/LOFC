using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card : MonoBehaviour
{
    public string cardName;
    public string displayName;
    public Sprite cardArt;
    public int rarity;
    public char side;
    public string range;
    public int atkFreq;
    public int attack;
    public int defense;
    public double attack_mult;
    public double defense_mult;
    public int level;
    public int HP;
    public string atkPatern;
    public string NumofATKs;
    public List<string> tags;
    public bool inForm;
    public int accuracy;
    public int evasion;
    public int cost;
    public string skill;
    public double skillLevel;
    public int baseSkillLevel;
    public double skillLevMult;
    public string cardDescript;
    public int X;
    public int Y;
}
