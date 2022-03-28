using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buildTimer2 : MonoBehaviour
{
    public float timer;
    public Text panel2Time;
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
            playerCards.hanger[1].built = false;
            panel2Time.gameObject.SetActive(true);

            if (playerCards.hanger[1].built == false)
            {
                timer -= Time.deltaTime;
                TimeSpan time = TimeSpan.FromSeconds(timer);
                panel2Time.text = time.ToString("hh':'mm':'ss");

                if (timer < 0)
                {
                    panel2Time.gameObject.SetActive(false);
                    playerCards.hanger[1].built = true;
                }

            }
        }
    }

    void getBuildTime()
    {
        if ((playerCards.hanger[1] != null) && (playerCards.hanger[1].built == false))
        {
            timer = playerCards.hanger[1].buildTime;
            inHanger = true;
        }
    }
}
