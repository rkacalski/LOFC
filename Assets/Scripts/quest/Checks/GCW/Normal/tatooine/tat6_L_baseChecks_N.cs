using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tat6_L_baseChecks_N : MonoBehaviour
{
    public bool tat6_1_check()
    {
        if (questProgress.tat6_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat6_2_check()
    {
        if (questProgress.tat6_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat6_3_check()
    {
        if (questProgress.tat6_2_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat6_4_check()
    {
        if (questProgress.tat6_3_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat6_5_check()
    {
        if (questProgress.tat6_4_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat6_6_check()
    {
        if (questProgress.tat6_5_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
}
