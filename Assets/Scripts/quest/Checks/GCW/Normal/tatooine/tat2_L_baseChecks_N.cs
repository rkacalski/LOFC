using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tat2_L_baseChecks_N : MonoBehaviour
{
    public bool tat2_1_check()
    {
        if (questProgress.tat2_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat2_2_check()
    {
        if (questProgress.tat2_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat2_3_check()
    {
        if (questProgress.tat2_2_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat2_4_check()
    {
        if (questProgress.tat2_3_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat2_5_check()
    {
        if (questProgress.tat2_4_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat2_6_check()
    {
        if (questProgress.tat2_5_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
}
