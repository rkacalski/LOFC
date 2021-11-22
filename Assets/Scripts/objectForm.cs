using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card/Vehicle")]
public class objectForm : ScriptableObject
{
    public string type;
    public string objectName;
    public string displayName;
    public Sprite art;
    public int rarity;
    public char side;
    public string range;
    public double atkFreq;
    public int attack;
    public int defense;
    public double attack_mult;
    public double defense_mult;
    public int level;
    public int HP;
    public string atkPatern;
    public bool inForm;
    public int accuracy;
    public int evasion;
    public List<string> cardTags = new List<string>();
    public int cost;
    public string skill;
    public int skillLevel;
    public double skillBase;
    public double skillMult;
    public string skillDescript;
    public string Descript;
    public int X;
    public int Y;
    public string numPiolts;
    public string numCoPiolts;
    public int numParts;
    public int onGridPositionX;
    public int onGridPositionY;
}
