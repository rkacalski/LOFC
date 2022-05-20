using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ds_L_selChecks_N : MonoBehaviour
{
    int count2;
    int count3;
    int count4;
    int count5;
    int count6;

    public bool ds2_check()
    {
        for (int i = 0; i < questProgress.ds1_L_N.Count; i++)
        {
            if (questProgress.ds1_L_N[i] == true)
            {
                count2 += 1;
            }
        }

        if (count2.Equals(6))
        {
            return true;
        }
        return false;
    }


    public bool ds3_check()
    {
        for (int i = 0; i < questProgress.ds2_L_N.Count; i++)
        {
            if (questProgress.ds2_L_N[i] == true)
            {
                count3 += 1;
            }
        }

        if (count3.Equals(6))
        {
            return true;
        }
        return false;
    }


    public bool ds4_check()
    {
        for (int i = 0; i < questProgress.ds3_L_N.Count; i++)
        {
            if (questProgress.ds3_L_N[i] == true)
            {
                count4 += 1;
            }
        }

        if (count4.Equals(6))
        {
            return true;
        }
        return false;
    }


    public bool ds5_check()
    {
        for (int i = 0; i < questProgress.ds4_L_N.Count; i++)
        {
            if (questProgress.ds4_L_N[i] == true)
            {
                count5 += 1;
            }
        }

        if (count5.Equals(6))
        {
            return true;
        }
        return false;
    }


    public bool ds6_check()
    {
        for (int i = 0; i < questProgress.ds5_L_N.Count; i++)
        {
            if (questProgress.ds5_L_N[i] == true)
            {
                count6 += 1;
            }
        }

        if (count6.Equals(6))
        {
            return true;
        }
        return false;
    }
}
