using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class questHomeUI : MonoBehaviour
{
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
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void cwNormalButton()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void cwNormalHard()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void torNormalButton()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void torNormalHard()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void kotorNormalButton()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void kotorNormalHard()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void tcwNormalButton()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void tcwNormalHard()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void yvNormalButton()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void yvNormalHard()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void legNormalButton()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void legNormalHard()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }
}
