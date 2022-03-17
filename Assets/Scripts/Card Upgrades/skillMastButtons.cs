using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skillMastButtons : MonoBehaviour
{
    public void homeButton()
    {
        SceneManager.LoadScene("Home Screen");
        //Manager
        skillManager.card1 = null;
        skillManager.card1Originalskill = 0;
        skillManager.card1newskill = 0;
        skillManager.cardSelected = false;
        skillManager.sortedBinder = null;
        skillManager.startingCardLevel = 0;
        skillManager.startingLvlValue = 0;

        //Select
        skillMastSelect.cardPosinList = -1;
    }
}
