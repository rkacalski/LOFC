using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questCheck : MonoBehaviour
{
    public List<GameObject> LockedImages = new List<GameObject>();
    public bool tat;
    public bool cwcheck;

    //Do UI stuff in questHomeUI
    void Start()
    {
        //tat = true;
        cwcheck = CWcheck();

        if(cwcheck == true)
        {
            LockedImages[0].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CWcheck()
    {
        if(tat == true)
        {
            return true;
        }
        return false;
    }
}
