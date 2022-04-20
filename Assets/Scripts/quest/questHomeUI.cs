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
        SceneManager.LoadScene("questTest");
    }
}
