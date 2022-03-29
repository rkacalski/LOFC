using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class playerCards
{
    public static List<Card> userCards = new List<Card>();
    public static List<Card> supportCards = new List<Card>();
    public static vehicle[] hanger = new vehicle[4];
    public static Card[] forTrade = new Card[5];
    public static Card[] wishlist = new Card[5];
    public static int playerCost;

    public static Card[,] mainForm = new Card[6, 3];
    public static int mainBattleStrength;
    public static int mainATK;
    public static int mainDEF;

    public static Card[,] gcwQuestForm_Light = new Card[6, 3];
    public static int gcwQuestBattleStrength_light;
    public static int gcwQuestATK_light;
    public static int gcwQuestDEF_light;

    public static Card[,] gcwQuestForm_Dark = new Card[6, 3];
    public static int gcwQuestBattleStrength_dark;
    public static int gcwQuestATK_dark;
    public static int gcwQuestDEF_dark;

    public static Card[,] cwQuestForm_Light = new Card[6, 3];
    public static int cwQuestBattleStrength_light;
    public static int cwQuestATK_light;
    public static int cwQuestDEF_light;

    public static Card[,] cwQuestForm_Dark = new Card[6, 3];
    public static int cwQuestBattleStrength_dark;
    public static int cwQuestATK_dark;
    public static int cwQuestDEF_dark;

}
