using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tat4_L_baseChecks_N : MonoBehaviour
{
    public bool tat4_1_check()
    {
        if (questProgress.tat4_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat4_2_check()
    {
        if (questProgress.tat4_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat4_3_check()
    {
        if (questProgress.tat4_2_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat4_4_check()
    {
        if (questProgress.tat4_3_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat4_5_check()
    {
        if (questProgress.tat4_4_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat4_6_check()
    {
        if (questProgress.tat4_5_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
}
