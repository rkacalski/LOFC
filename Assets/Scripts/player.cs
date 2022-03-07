using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public string player_name;
    private int player_id;
    public static int player_level;


    public static int player_xp;
    public static int player_maxXp;
    public static int player_ep;
    public static int player_maxEp;
    public static int player_bp;
    public static int player_maxBp;

    public static int credits;
    public static int training_remotes;
    public static int crystals;
    public static int allyPoints;

    //Quest
    public static int numBronzeContainers;
    public static int numSilverContainers;
    public static int numGoldContainers;
    public static string currentQuestMap;
    public static bool mapInProgress = false;
    public static float questPosX = 0;
    public static float questPosY = 0;
    public static bool cont1found = false;
    public static bool cont2found = false;
    public static bool cont3found = false;
    public static bool cont4found = false;
    public static bool cont5found = false;
    public static bool cont6found = false;
    public static bool cont7found = false;
    public static bool cont8found = false;
    public static bool cont9found = false;
    public static bool cont10found = false;
    public static bool cont11found = false;
    public static bool cont12found = false;
}
