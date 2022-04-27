using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tat_L_baseChecks_N : MonoBehaviour
{
    public bool tat1_1_check()
    {
        if(questProgress.tat1_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat1_2_check()
    {
        if(questProgress.tat1_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool tat1_3_check()
    {
        if (questProgress.tat1_2_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat1_4_check()
    {
        if (questProgress.tat1_3_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat1_5_check()
    {
        if (questProgress.tat1_4_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool tat1_6_check()
    {
        if (questProgress.tat1_5_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
}
