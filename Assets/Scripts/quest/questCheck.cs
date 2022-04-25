using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questCheck : MonoBehaviour
{
    public bool tat;
    public bool cwcheck;
    public int numLevels;

    //Do UI stuff in questHomeUI
    void Start()
    {
        //tat = true;
        cwcheck = CWcheck();

        if(cwcheck == true)
        {
            print("workinh");
        }
    }

    public bool tat1()
    {
        for (int i = 0; i < questProgress.tat1.Length; i++)
        {
            questProgress.tat1[i] = true;
            if (questProgress.tat1[i] == true)
            {
                numLevels += 1;
            }
        }

        if(numLevels.Equals(6))
        {
            return true;
        }

        return false;
    }

    public bool tat2()
    {
        return false;
    }

    public bool tat3()
    {
        return false;
    }

    public bool tat4()
    {
        return false;
    }

    public bool tat5()
    {
        return false;
    }

    public bool tat6()
    {
        return false;
    }

    public bool CWcheck()
    {
        bool check = tat1();
        if (check == true)
        {
            return true;
        }
        return false;
    }
}
