using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ds2_L_baseChecks_N : MonoBehaviour
{
    public bool ds2_1_check()
    {
        if (questProgress.ds2_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool ds2_2_check()
    {
        if (questProgress.ds2_1_complete_L_N == true)
        {
            return true;
        }
        return false;
    }

    public bool ds2_3_check()
    {
        if (questProgress.ds2_2_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool ds2_4_check()
    {
        if (questProgress.ds2_3_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool ds2_5_check()
    {
        if (questProgress.ds2_4_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
    public bool ds2_6_check()
    {
        if (questProgress.ds2_5_complete_L_N == true)
        {
            return true;
        }
        return false;
    }
}
