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

    // Start is called before the first frame update
    void Start()
    {
        print(playerCards.userCards[0]);
        print(string.IsNullOrEmpty(playerCards.userCards[0].cardName));
        //print(string.IsNullOrEmpty(playerCards.forTrade[1].cardName));
        displayCards();
    }

    public void displayCards()
    {
        for(int i = 0; i < 5; i++)
        {
            //print(playerCards.forTrade[i].cardName);
            if(string.IsNullOrEmpty(playerCards.forTrade[i].cardName))
            {
                print("Empty");
                continue;
            }
            if (string.IsNullOrEmpty(playerCards.forTrade[i].cardName))
            {
                print("Not empty");
                cardSlots[i].GetComponent<Image>().sprite = playerCards.forTrade[i].cardArt;
            }
        }

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
    }
}
