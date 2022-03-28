using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buildTimer4 : MonoBehaviour
{
    public float timer;
    public Text panel4Time;
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
            playerCards.hanger[3].built = false;
            panel4Time.gameObject.SetActive(true);

            if (playerCards.hanger[3].built == false)
            {
                timer -= Time.deltaTime;
                TimeSpan time = TimeSpan.FromSeconds(timer);
                panel4Time.text = time.ToString("hh':'mm':'ss");

                if (timer < 0)
                {
                    panel4Time.gameObject.SetActive(false);
                    playerCards.hanger[3].built = true;
                }

            }
        }
    }

    void getBuildTime()
    {
        if ((playerCards.hanger[3] != null) && (playerCards.hanger[3].built == false))
        {
            timer = playerCards.hanger[3].buildTime;
            inHanger = true;
        }
    }
}
