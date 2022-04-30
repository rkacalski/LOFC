using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tat5_L_baseChecks_N : MonoBehaviour
{
    public bool tat5_1_check()
    {
        if (questProgress.tat5_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat5_2_check()
    {
        if (questProgress.tat5_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat5_3_check()
    {
        if (questProgress.tat5_2_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat5_4_check()
    {
        if (questProgress.tat5_3_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat5_5_check()
    {
        if (questProgress.tat5_4_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat5_6_check()
    {
        if (questProgress.tat5_5_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
}
