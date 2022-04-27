using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questProgress : MonoBehaviour
{
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
    public static bool[] tat1_L = new bool[] { tat1_1_complete_L_N, tat1_2_complete_L_N, tat1_3_complete_L_N, tat1_4_complete_L_N, tat1_5_complete_L_N, tat1_6_complete_L_N };
    public static bool[] tat1_D = new bool[] { tat1_1_complete_D_N, tat1_2_complete_D_N, tat1_3_complete_D_N, tat1_4_complete_D_N, tat1_5_complete_D_N, tat1_6_complete_D_N };

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
    public static bool[] tat2_L = new bool[] { tat2_1_complete_L_N, tat2_2_complete_L_N, tat2_3_complete_L_N, tat2_4_complete_L_N, tat2_5_complete_L_N, tat2_6_complete_L_N };
    public static bool[] tat2_D = new bool[] { tat2_1_complete_D_N, tat2_2_complete_D_N, tat2_3_complete_D_N, tat2_4_complete_D_N, tat2_5_complete_D_N, tat2_6_complete_D_N };

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
    public static bool[] tat3_L = new bool[] { tat3_1_complete_L_N, tat3_2_complete_L_N, tat3_3_complete_L_N, tat3_4_complete_L_N, tat3_5_complete_L_N, tat3_6_complete_L_N };
    public static bool[] tat3_D = new bool[] { tat3_1_complete_D_N, tat3_2_complete_D_N, tat3_3_complete_D_N, tat3_4_complete_D_N, tat3_5_complete_D_N, tat3_6_complete_D_N };

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
    public static bool[] tat4_L = new bool[] { tat4_1_complete_L_N, tat4_2_complete_L_N, tat4_3_complete_L_N, tat4_4_complete_L_N, tat4_5_complete_L_N, tat4_6_complete_L_N };
    public static bool[] tat4_D = new bool[] { tat4_1_complete_D_N, tat4_2_complete_D_N, tat4_3_complete_D_N, tat4_4_complete_D_N, tat4_5_complete_D_N, tat4_6_complete_D_N };

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
    public static bool[] tat5_L = new bool[] { tat5_1_complete_L_N, tat5_2_complete_L_N, tat5_3_complete_L_N, tat5_4_complete_L_N, tat5_5_complete_L_N, tat5_6_complete_L_N};
    public static bool[] tat5_D = new bool[] { tat5_1_complete_D_N, tat5_2_complete_D_N, tat5_3_complete_D_N, tat5_4_complete_D_N, tat5_5_complete_D_N, tat5_6_complete_D_N};

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
    public static bool[] tat6_L = new bool[] { tat6_1_complete_L_N, tat6_2_complete_L_N, tat6_3_complete_L_N, tat6_4_complete_L_N, tat6_5_complete_L_N, tat6_6_complete_L_N };
    public static bool[] tat6_D = new bool[] { tat6_1_complete_D_N, tat6_2_complete_D_N, tat6_3_complete_D_N, tat6_4_complete_D_N, tat6_5_complete_D_N, tat6_6_complete_D_N };

    //DS
    public static bool ds1_1_complete;
    public static bool ds1_2_complete;
    public static bool ds1_3_complete;
    public static bool ds1_4_complete;
    public static bool ds1_5_complete;
    public static bool ds1_6_complete;

    public static bool ds2_1_complete;
    public static bool ds2_2_complete;
    public static bool ds2_3_complete;
    public static bool ds2_4_complete;
    public static bool ds2_5_complete;
    public static bool ds2_6_complete;

    public static bool ds3_1_complete;
    public static bool ds3_2_complete;
    public static bool ds3_3_complete;
    public static bool ds3_4_complete;
    public static bool ds3_5_complete;
    public static bool ds3_6_complete;

    public static bool ds4_1_complete;
    public static bool ds4_2_complete;
    public static bool ds4_3_complete;
    public static bool ds4_4_complete;
    public static bool ds4_5_complete;
    public static bool ds4_6_complete;

    public static bool ds5_1_complete;
    public static bool ds5_2_complete;
    public static bool ds5_3_complete;
    public static bool ds5_4_complete;
    public static bool ds5_5_complete;
    public static bool ds5_6_complete;

    public static bool ds6_1_complete;
    public static bool ds6_2_complete;
    public static bool ds6_3_complete;
    public static bool ds6_4_complete;
    public static bool ds6_5_complete;
    public static bool ds6_6_complete;

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
