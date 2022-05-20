using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questProgress : MonoBehaviour
{
    public static bool listsCreated;
    //GCW (Tatooine, Death Star, Yavin 4, Hoth, Bespin, Endor) ///////////////////////////////////////////////////////////////////
    //Tat
    public static bool tat1_1_complete_L_N;
    public static bool tat1_2_complete_L_N;
    public static bool tat1_3_complete_L_N;
    public static bool tat1_4_complete_L_N;
    public static bool tat1_5_complete_L_N;
    public static bool tat1_6_complete_L_N;
    public static bool tat1_1_complete_D_N;
    public static bool tat1_2_complete_D_N;
    public static bool tat1_3_complete_D_N;
    public static bool tat1_4_complete_D_N;
    public static bool tat1_5_complete_D_N;
    public static bool tat1_6_complete_D_N;
    public static List<bool> tat1_L_N = new List<bool>();
    public static List<bool> tat1_D_N = new List<bool>();

    public static bool tat2_1_complete_L_N;
    public static bool tat2_2_complete_L_N;
    public static bool tat2_3_complete_L_N;
    public static bool tat2_4_complete_L_N;
    public static bool tat2_5_complete_L_N;
    public static bool tat2_6_complete_L_N;
    public static bool tat2_1_complete_D_N;
    public static bool tat2_2_complete_D_N;
    public static bool tat2_3_complete_D_N;
    public static bool tat2_4_complete_D_N;
    public static bool tat2_5_complete_D_N;
    public static bool tat2_6_complete_D_N;
    public static List<bool> tat2_L_N = new List<bool>();
    public static List<bool> tat2_D_N = new List<bool>();

    public static bool tat3_1_complete_L_N;
    public static bool tat3_2_complete_L_N;
    public static bool tat3_3_complete_L_N;
    public static bool tat3_4_complete_L_N;
    public static bool tat3_5_complete_L_N;
    public static bool tat3_6_complete_L_N;
    public static bool tat3_1_complete_D_N;
    public static bool tat3_2_complete_D_N;
    public static bool tat3_3_complete_D_N;
    public static bool tat3_4_complete_D_N;
    public static bool tat3_5_complete_D_N;
    public static bool tat3_6_complete_D_N;
    public static List<bool> tat3_L_N = new List<bool>();
    public static List<bool> tat3_D_N = new List<bool>();

    public static bool tat4_1_complete_L_N;
    public static bool tat4_2_complete_L_N;
    public static bool tat4_3_complete_L_N;
    public static bool tat4_4_complete_L_N;
    public static bool tat4_5_complete_L_N;
    public static bool tat4_6_complete_L_N;
    public static bool tat4_1_complete_D_N;
    public static bool tat4_2_complete_D_N;
    public static bool tat4_3_complete_D_N;
    public static bool tat4_4_complete_D_N;
    public static bool tat4_5_complete_D_N;
    public static bool tat4_6_complete_D_N;
    public static List<bool> tat4_L_N = new List<bool>();
    public static List<bool> tat4_D_N = new List<bool>();

    public static bool tat5_1_complete_L_N;
    public static bool tat5_2_complete_L_N;
    public static bool tat5_3_complete_L_N;
    public static bool tat5_4_complete_L_N;
    public static bool tat5_5_complete_L_N;
    public static bool tat5_6_complete_L_N;
    public static bool tat5_1_complete_D_N;
    public static bool tat5_2_complete_D_N;
    public static bool tat5_3_complete_D_N;
    public static bool tat5_4_complete_D_N;
    public static bool tat5_5_complete_D_N;
    public static bool tat5_6_complete_D_N;
    public static List<bool> tat5_L_N = new List<bool>();
    public static List<bool> tat5_D_N = new List<bool>();

    public static bool tat6_1_complete_L_N;
    public static bool tat6_2_complete_L_N;
    public static bool tat6_3_complete_L_N;
    public static bool tat6_4_complete_L_N;
    public static bool tat6_5_complete_L_N;
    public static bool tat6_6_complete_L_N;
    public static bool tat6_1_complete_D_N;
    public static bool tat6_2_complete_D_N;
    public static bool tat6_3_complete_D_N;
    public static bool tat6_4_complete_D_N;
    public static bool tat6_5_complete_D_N;
    public static bool tat6_6_complete_D_N;
    public static List<bool> tat6_L_N = new List<bool>();
    public static List<bool> tat6_D_N = new List<bool>();

    //DS
    public static bool ds1_1_complete_L_N;
    public static bool ds1_2_complete_L_N;
    public static bool ds1_3_complete_L_N;
    public static bool ds1_4_complete_L_N;
    public static bool ds1_5_complete_L_N;
    public static bool ds1_6_complete_L_N;
    public static bool ds1_1_complete_D_N;
    public static bool ds1_2_complete_D_N;
    public static bool ds1_3_complete_D_N;
    public static bool ds1_4_complete_D_N;
    public static bool ds1_5_complete_D_N;
    public static bool ds1_6_complete_D_N;
    public static List<bool> ds1_L_N = new List<bool>();
    public static List<bool> ds1_D_N = new List<bool>();

    public static bool ds2_1_complete_L_N;
    public static bool ds2_2_complete_L_N;
    public static bool ds2_3_complete_L_N;
    public static bool ds2_4_complete_L_N;
    public static bool ds2_5_complete_L_N;
    public static bool ds2_6_complete_L_N;
    public static bool ds2_1_complete_D_N;
    public static bool ds2_2_complete_D_N;
    public static bool ds2_3_complete_D_N;
    public static bool ds2_4_complete_D_N;
    public static bool ds2_5_complete_D_N;
    public static bool ds2_6_complete_D_N;
    public static List<bool> ds2_L_N = new List<bool>();
    public static List<bool> ds2_D_N = new List<bool>();

    public static bool ds3_1_complete_L_N;
    public static bool ds3_2_complete_L_N;
    public static bool ds3_3_complete_L_N;
    public static bool ds3_4_complete_L_N;
    public static bool ds3_5_complete_L_N;
    public static bool ds3_6_complete_L_N;
    public static bool ds3_1_complete_D_N;
    public static bool ds3_2_complete_D_N;
    public static bool ds3_3_complete_D_N;
    public static bool ds3_4_complete_D_N;
    public static bool ds3_5_complete_D_N;
    public static bool ds3_6_complete_D_N;
    public static List<bool> ds3_L_N = new List<bool>();
    public static List<bool> ds3_D_N = new List<bool>();

    public static bool ds4_1_complete_L_N;
    public static bool ds4_2_complete_L_N;
    public static bool ds4_3_complete_L_N;
    public static bool ds4_4_complete_L_N;
    public static bool ds4_5_complete_L_N;
    public static bool ds4_6_complete_L_N;
    public static bool ds4_1_complete_D_N;
    public static bool ds4_2_complete_D_N;
    public static bool ds4_3_complete_D_N;
    public static bool ds4_4_complete_D_N;
    public static bool ds4_5_complete_D_N;
    public static bool ds4_6_complete_D_N;
    public static List<bool> ds4_L_N = new List<bool>();
    public static List<bool> ds4_D_N = new List<bool>();

    public static bool ds5_1_complete_L_N;
    public static bool ds5_2_complete_L_N;
    public static bool ds5_3_complete_L_N;
    public static bool ds5_4_complete_L_N;
    public static bool ds5_5_complete_L_N;
    public static bool ds5_6_complete_L_N;
    public static bool ds5_1_complete_D_N;
    public static bool ds5_2_complete_D_N;
    public static bool ds5_3_complete_D_N;
    public static bool ds5_4_complete_D_N;
    public static bool ds5_5_complete_D_N;
    public static bool ds5_6_complete_D_N;
    public static List<bool> ds5_L_N = new List<bool>();
    public static List<bool> ds5_D_N = new List<bool>();

    public static bool ds6_1_complete_L_N;
    public static bool ds6_2_complete_L_N;
    public static bool ds6_3_complete_L_N;
    public static bool ds6_4_complete_L_N;
    public static bool ds6_5_complete_L_N;
    public static bool ds6_6_complete_L_N;
    public static bool ds6_1_complete_D_N;
    public static bool ds6_2_complete_D_N;
    public static bool ds6_3_complete_D_N;
    public static bool ds6_4_complete_D_N;
    public static bool ds6_5_complete_D_N;
    public static bool ds6_6_complete_D_N;
    public static List<bool> ds6_L_N = new List<bool>();
    public static List<bool> ds6_D_N = new List<bool>();

    //Y4
    public static bool yav1_1_complete;
    public static bool yav1_2_complete;
    public static bool yav1_3_complete;
    public static bool yav1_4_complete;
    public static bool yav1_5_complete;
    public static bool yav1_6_complete;

    public static bool yav2_1_complete;
    public static bool yav2_2_complete;
    public static bool yav2_3_complete;
    public static bool yav2_4_complete;
    public static bool yav2_5_complete;
    public static bool yav2_6_complete;

    public static bool yav3_1_complete;
    public static bool yav3_2_complete;
    public static bool yav3_3_complete;
    public static bool yav3_4_complete;
    public static bool yav3_5_complete;
    public static bool yav3_6_complete;

    public static bool yav4_1_complete;
    public static bool yav4_2_complete;
    public static bool yav4_3_complete;
    public static bool yav4_4_complete;
    public static bool yav4_5_complete;
    public static bool yav4_6_complete;

    public static bool yav5_1_complete;
    public static bool yav5_2_complete;
    public static bool yav5_3_complete;
    public static bool yav5_4_complete;
    public static bool yav5_5_complete;
    public static bool yav5_6_complete;

    public static bool yav6_1_complete;
    public static bool yav6_2_complete;
    public static bool yav6_3_complete;
    public static bool yav6_4_complete;
    public static bool yav6_5_complete;
    public static bool yav6_6_complete;

    //CW

    //TOR

    //KOTOR

    //COLD WAR

    //YV

    //Leg
}
