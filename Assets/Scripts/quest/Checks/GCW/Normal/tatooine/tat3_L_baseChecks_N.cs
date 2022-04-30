using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tat3_L_baseChecks_N : MonoBehaviour
{
    public bool tat3_1_check()
    {
        if (questProgress.tat3_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat3_2_check()
    {
        if (questProgress.tat3_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat3_3_check()
    {
        if (questProgress.tat3_2_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat3_4_check()
    {
        if (questProgress.tat3_3_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat3_5_check()
    {
        if (questProgress.tat3_4_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat3_6_check()
    {
        if (questProgress.tat3_5_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
}
