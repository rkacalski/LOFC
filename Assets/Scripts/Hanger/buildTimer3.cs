using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buildTimer3 : MonoBehaviour
{
    public static float timer;
    public Text panel3Time;
    public static bool inHanger;

    void Start()
    {
        getBuildTime();
        if(timer != 0)
        {
            DontDestroyOnLoad(gameObject);
        }
        print(timer);
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        if (inHanger == true)
        {
            playerCards.hanger[2].built = false;
            panel3Time.gameObject.SetActive(true);

            if (playerCards.hanger[2].built == false)
            {
                timer -= Time.deltaTime;
                TimeSpan time = TimeSpan.FromSeconds(timer);
                panel3Time.text = time.ToString("hh':'mm':'ss");

                if(timer < 0)
                {
                    panel3Time.gameObject.SetActive(false);
                    playerCards.hanger[2].built = true;
                    Destroy(this.gameObject);
                }

            }
        }
    }

    void getBuildTime()
    {
        if ((playerCards.hanger[2] != null) && (playerCards.hanger[2].built == false))
        {
            timer = playerCards.hanger[2].buildTime;
            inHanger = true;
        }
    }
}
