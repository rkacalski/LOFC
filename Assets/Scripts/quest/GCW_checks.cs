using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCW_checks : MonoBehaviour
{
    int count;

    public bool DS_L_N_Check()
    {
        for(int i = 0; i < questProgress.tat1_L_N.Count; i++)
        {
            if(questProgress.tat1_L_N[i] == true)
            {
                count += 1;
            }
        }
        for (int i = 0; i < questProgress.tat2_L_N.Count; i++)
        {
            if (questProgress.tat2_L_N[i] == true)
            {
                count += 1;
            }
        }
        for (int i = 0; i < questProgress.tat3_L_N.Count; i++)
        {
            if (questProgress.tat3_L_N[i] == true)
            {
                count += 1;
            }
        }
        for (int i = 0; i < questProgress.tat4_L_N.Count; i++)
        {
            if (questProgress.tat4_L_N[i] == true)
            {
                count += 1;
            }
        }
        for (int i = 0; i < questProgress.tat5_L_N.Count; i++)
        {
            if (questProgress.tat5_L_N[i] == true)
            {
                count += 1;
            }
        }
        for (int i = 0; i < questProgress.tat6_L_N.Count; i++)
        {
            if (questProgress.tat6_L_N[i] == true)
            {
                count += 1;
            }
        }

        if (count.Equals(36))
        {
            count = 0;
            return true;
        }

        count = 0;
        return false;
    }

    public bool DS_D_N_Check()
    {
        for (int i = 0; i < questProgress.tat1_D_N.Count; i++)
        {
            if (questProgress.tat1_D_N[i] == true)
            {
                count += 1;
            }
        }
        for (int i = 0; i < questProgress.tat2_D_N.Count; i++)
        {
            if (questProgress.tat2_D_N[i] == true)
            {
                count += 1;
            }
        }
        for (int i = 0; i < questProgress.tat3_D_N.Count; i++)
        {
            if (questProgress.tat3_D_N[i] == true)
            {
                count += 1;
            }
        }
        for (int i = 0; i < questProgress.tat4_D_N.Count; i++)
        {
            if (questProgress.tat4_D_N[i] == true)
            {
                count += 1;
            }
        }
        for (int i = 0; i < questProgress.tat5_D_N.Count; i++)
        {
            if (questProgress.tat5_D_N[i] == true)
            {
                count += 1;
            }
        }
        for (int i = 0; i < questProgress.tat6_D_N.Count; i++)
        {
            if (questProgress.tat6_D_N[i] == true)
            {
                count += 1;
            }
        }

        if (count.Equals(36))
        {
            count = 0;
            return true;
        }

        count = 0;
        return false;
    }

    //Do other checks when planets are created
}
