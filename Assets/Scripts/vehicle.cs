using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class vehicle : MonoBehaviour
{
    public string vehicleName;
    public string displayName;
    public Sprite art;
    public string range;
    public string atkPatern;
    public int atkFreq;
    public int attack;
    public int defense;
    public int accuracy;
    public int evasion;
    public int cost;
    public int level;
    public int HP;
    public bool inForm;
    public bool built;
    public float buildTime;
    public string vehicleDescript;
    public int X;
    public int Y;
    public Card pilot;
    public List<Card> Pilot = new List<Card>();
    public int numCoPilots;
    public List<Card> coPilots = new List<Card>();
    public int numParts;
}
