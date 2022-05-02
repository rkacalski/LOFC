using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questCheck : MonoBehaviour
{
    int cwCheck1;
    int cwCheck2;

    public bool CWcheck()
    {
        for(int i = 0; i < questProgress.tat1_L_N.Count; i++)
        {
            if (questProgress.tat1_L_N[i] == true)
            {
                cwCheck1 += 1;
            }
        }

        for (int i = 0; i < questProgress.tat1_D_N.Count; i++)
        {
            if (questProgress.tat1_D_N[i] == true)
            {
                cwCheck2 += 1;
            }
        }

        if(cwCheck1.Equals(6) || cwCheck2.Equals(6))
        {
            return true;
        }

        return false;
    }
}
