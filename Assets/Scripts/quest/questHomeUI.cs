using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class questHomeUI : MonoBehaviour
{
    public questCheck checks;
    public GameObject cwLocked;
    public GameObject torLocked;
    public GameObject kotorLocked;
    public GameObject tcwLocked;
    public GameObject yvLocked;
    public GameObject legLocked;

    public Text gcwProgress;
    public Text cwProgress;
    public Text torProgress;
    public Text kotorProgress;
    public Text tcwProgress;
    public Text yvProgress;
    public Text legProgress;

    public int count;
    public int finalNum;

    void Start()
    {
        print(questProgress.tat1_L[0]);

        //cw check and progress
        if (checks.CWcheck() == true)
        {
            getNumbers(1);
            cwLocked.SetActive(false);
        }
    }



    public void currentLevelButton()
    {
        if(!String.IsNullOrEmpty(player.currentQuestMap))
        {
            SceneManager.LoadScene(player.currentQuestMap);
        }
    }

    public void gcwNormalButton()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void gcwNormalHard()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void cwNormalButton()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void cwNormalHard()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void torNormalButton()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void torNormalHard()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void kotorNormalButton()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void kotorNormalHard()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void tcwNormalButton()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void tcwNormalHard()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void yvNormalButton()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void yvNormalHard()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void legNormalButton()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void legNormalHard()
    {
        //SceneManager.LoadScene("GCW_main_normal");
    }

    public void getNumbers(int Level)
    {
        if(Level.Equals(1))
        {
            // Tat
            for(int i = 0; i < questProgress.tat1_L.Length; i++)
            {
                if (questProgress.tat1_L[i] == true)
                {
                    count += 1;
                }
            }

            for (int i = 0; i < questProgress.tat1_D.Length; i++)
            {
                if (questProgress.tat1_D[i] == true)
                {
                    count += 1;
                }
            }
            //loop for tat2 L
            //loop for tat2 D
            //loop for tat3 L
            //loop for tat3 D
            //loop for tat4 L
            //loop for tat4 D
            //loop for tat5 L
            //loop for tat5 D
            //loop for tat6 L
            //loop for tat6 D

            //TAT Label update      add 72 to each additional planet DS 144, y4 216 etc.
            if (count.Equals(72))
            {
                finalNum += 1;
            }

            // Death Star
            // Yavin 4
            // Hoth
            // Bespin
            // Endor

            // update progress label and reset count and finNum (72level per planet);
            gcwProgress.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + finalNum.ToString() + "/24";
            count = 0;
            finalNum = 0;
        }
    }
}
