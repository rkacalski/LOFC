using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ds_L_baseChecks_N : MonoBehaviour
{
    public bool ds1_1_check()
    {
        if (questProgress.ds1_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool ds1_2_check()
    {
        if (questProgress.ds1_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool ds1_3_check()
    {
        if (questProgress.ds1_2_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool ds1_4_check()
    {
        if (questProgress.ds1_3_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool ds1_5_check()
    {
        if (questProgress.ds1_4_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool ds1_6_check()
    {
        if (questProgress.ds1_5_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
}
