using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class questReset : MonoBehaviour
{

    public void questCompleteHomeButton()
    {
        SceneManager.LoadScene("Home Screen");
        resetQuest();
    }

    public void resetQuest()
    {
        //player
        player.numBronzeContainers = 0;
        player.numSilverContainers = 0;
        player.numGoldContainers = 0;
        player.currentQuestMap = "";
        player.mapInProgress = false;
        player.questPosX = 0;
        player.questPosY = 0;
        player.cont1found = false;
        player.cont2found = false;
        player.cont3found = false;
        player.cont4found = false;
        player.cont5found = false;
        player.cont6found = false;
        player.cont7found = false;
        player.cont8found = false;
        player.cont9found = false;
        player.cont10found = false;
        player.cont11found = false;
        player.cont12found = false;

        //NumContainers
        numContainer.currentNumContainers = 0;

        //Quest Manager
        questManager.crate1 = "";
        questManager.crate2 = "";
        questManager.crate3 = "";
        questManager.crate4 = "";
        questManager.crate5 = "";
        questManager.crate6 = "";
        questManager.crate7 = "";
        questManager.crate8 = "";
        questManager.crate9 = "";
        questManager.crate10 = "";
        questManager.crate11 = "";
        questManager.crate12 = "";
    }
    
}
