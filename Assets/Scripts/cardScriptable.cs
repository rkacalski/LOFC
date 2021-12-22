using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card")]
public class cardScriptable : ScriptableObject
{
    public string cardName;
    public string displayName;
    public Sprite art;
    public int rarity;
    public char side;
    public string range;
    public string atkPatern;
    public double atkFreq;
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
    public List<string> cardTags = new List<string>();
    public string cardDescript;
    public string skill;
    public int skillLevel;
    public double skillBase;
    public double skillMult;
    public string skillDescript;
    public int X;
    public int Y;
}
