using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tat_L_selChecks_N : MonoBehaviour
{
    int count2;
    int count3;
    int count4;
    int count5;
    int count6;

    public bool tat2_check()
    {
        for (int i = 0; i < questProgress.tat1_L_N.Count; i++)
        {
            if (questProgress.tat1_L_N[i] == true)
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

    
    public bool tat3_check()
    {
        for (int i = 0; i < questProgress.tat2_L_N.Count; i++)
        {
            if (questProgress.tat2_L_N[i] == true)
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

    
    public bool tat4_check()
    {
        for (int i = 0; i < questProgress.tat3_L_N.Count; i++)
        {
            if (questProgress.tat3_L_N[i] == true)
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

    
    public bool tat5_check()
    {
        for (int i = 0; i < questProgress.tat4_L_N.Count; i++)
        {
            if (questProgress.tat4_L_N[i] == true)
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

    
    public bool tat6_check()
    {
        for (int i = 0; i < questProgress.tat5_L_N.Count; i++)
        {
            if (questProgress.tat5_L_N[i] == true)
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
