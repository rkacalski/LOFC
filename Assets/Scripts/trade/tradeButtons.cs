using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tradeButtons : MonoBehaviour
{
    public GameObject selectedPopUpmenu;
    public Image popUpImage;

    void Start()
    {

        selectedPopUpmenu.transform.localScale = Vector2.zero;
    }

    public void closeWindow()
    {
        selectedPopUpmenu.transform.localScale = Vector2.zero;
    }

    // Buttons to determine select card

    public void newCard()
    {
        playerCards.forTrade[forTradeSelect.cardSlot] = null;
    }

    public void forTrade1()
    {
        if(playerCards.forTrade[0] == null)
        {
            forTradeSelect.cardSlot = 0;
            SceneManager.LoadScene("forTradeSelect");
        }
        if (playerCards.forTrade[0] != null)
        {
            forTradeSelect.cardSlot = 0;
            popUpImage.sprite = playerCards.forTrade[0].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
    }

}
