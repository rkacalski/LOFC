using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buildTimer1 : MonoBehaviour
{
    public float timer;
    public Text panel1Time;
    public static bool inHanger;

    int instatiate;

    void Start()
    {
        getBuildTime();
        if (timer != 0)
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inHanger == true)
        {
            playerCards.hanger[0].built = false;
            panel1Time.gameObject.SetActive(true);

            if (playerCards.hanger[0].built == false)
            {
                timer -= Time.deltaTime;
                TimeSpan time = TimeSpan.FromSeconds(timer);
                panel1Time.text = time.ToString("hh':'mm':'ss");

                if (timer < 0)
                {
                    panel1Time.gameObject.SetActive(false);
                    playerCards.hanger[0].built = true;
                }

            }
        }
    }

    void getBuildTime()
    {
        if ((playerCards.hanger[0] != null) && (playerCards.hanger[0].built == false))
        {
            timer = playerCards.hanger[0].buildTime;
            inHanger = true;
        }
    }
}
