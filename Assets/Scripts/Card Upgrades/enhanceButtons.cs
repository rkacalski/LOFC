using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enhanceButtons : MonoBehaviour
{
    public void homeButton()
    {
        SceneManager.LoadScene("Home Screen");
        //Manager
        cardManager.card1 = null;
        cardManager.card1OriginalATK = 0;
        cardManager.card1OrigonalDEF = 0;
        cardManager.sortedBinder = null;
        cardManager.card1newATK = 0;
        cardManager.card1newDEF = 0;
        cardManager.cardSelected = false;

        //Select
        cardSelect.card1PosinList = -1;
        cardSelect.card2PosinList = -1;
        cardSelect.card1Level = null;
        cardSelect.card2Level = null;
        cardSelect.card1rarity = 0;
        cardSelect.card2rarity = 0;
        cardSelect.card1Name = null;
        cardSelect.card2Name = null;
    }
}
