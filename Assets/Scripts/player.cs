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
    public static int oneStarHoloLight;
    public static int oneStarHoloDark;
    public static int oneStarHoloNuet;
    public static int twoStarHoloLight;
    public static int twoStarHoloDark;
    public static int twoStarHoloNuet;
    public static int threeStarHoloLight;
    public static int threeStarHoloDark;
    public static int threeStarHoloNuet;
    public static int fourStarHoloLight;
    public static int fourStarHoloDark;
    public static int fourStarHoloNuet;
    public static int fiveStarHoloLight;
    public static int fiveStarHoloDark;
    public static int fiveStarHoloNuet;

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

    //Blueprints
    public static int xwing1;
    public static int xwing2;
    public static int xwing3;
    public static int xwing4;
    public static int xwing5;
    public static int xwing6;

    public static int tieFighter1;
    public static int tieFighter2;
    public static int tieFighter3;
    public static int tieFighter4;
    public static int tieFighter5;
    public static int tieFighter6;

    public static int slaveOne1;
    public static int slaveOne2;
    public static int slaveOne3;
    public static int slaveOne4;
    public static int slaveOne5;
    public static int slaveOne6;

    public static int blizzardOne1;
    public static int blizzardOne2;
    public static int blizzardOne3;
    public static int blizzardOne4;
    public static int blizzardOne5;
    public static int blizzardOne6;
}
