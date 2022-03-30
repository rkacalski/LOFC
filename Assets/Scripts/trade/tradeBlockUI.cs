using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tradeBlockUI : MonoBehaviour
{
    public Image[] cardSlots;
    bool cardNull;

    // Start is called before the first frame update
    void Start()
    {
        displayCards();
    }

    public void displayCards()
    {
        for (int i = 0; i < playerCards.forTrade.Count; i++)
        {
            cardSlots[i].GetComponent<Image>().sprite = playerCards.forTrade[i].cardArt;
        }

        /*
        for (int i = 0; i < 5; i++)
        {
            if (playerCards.wishlist[i] == null)
            {
                continue;
            }
            if (playerCards.wishlist[i] != null)
            {
                cardSlots[i].GetComponent<Image>().sprite = playerCards.wishlist[i].cardArt;
            }
        }
        */
    }
}
