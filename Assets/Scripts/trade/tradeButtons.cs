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
    public Sprite defultSprite;
    public Image popUpImage;

    int spot;

    public Image Image1;
    public Image Image2;
    public Image Image3;
    public Image Image4;
    public Image Image5;

    int check;

    void Start()
    {
        selectedPopUpmenu.transform.localScale = Vector2.zero;
        doCheck();
    }

    public void closeWindow()
    {
        selectedPopUpmenu.transform.localScale = Vector2.zero;
    }

    // Buttons to determine select card

    public void newCard()
    {
        playerCards.forTrade.RemoveAt(forTradeSelect.cardSlot);
        if(spot.Equals(1))
        {
            Image1.GetComponent<Image>().sprite = defultSprite;
        }
        if (spot.Equals(2))
        {
            Image2.GetComponent<Image>().sprite = defultSprite;
        }
        if (spot.Equals(3))
        {
            Image3.GetComponent<Image>().sprite = defultSprite;
        }
        if (spot.Equals(4))
        {
            Image4.GetComponent<Image>().sprite = defultSprite;
        }
        if (spot.Equals(5))
        {
            Image5.GetComponent<Image>().sprite = defultSprite;
        }
        doCheck();
        selectedPopUpmenu.transform.localScale = Vector2.zero;
    }

    public void forTrade1()
    {
        if (check.Equals(1))
        {
            if (playerCards.forTrade.Count < 1)
            {
                forTradeSelect.cardSlot = 0;
                SceneManager.LoadScene("forTradeSelect");
            }
        }
        if (check.Equals(2))
        {
            spot = 1;
            forTradeSelect.cardSlot = 0;
            popUpImage.sprite = playerCards.forTrade[0].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
    }

    public void forTrade2()
    {
        if (check.Equals(2))
        {
            if (playerCards.forTrade.Count > 0 && playerCards.forTrade.Count < 2)
            {
                forTradeSelect.cardSlot = 1;
                SceneManager.LoadScene("forTradeSelect");
            }
        }
        if (check.Equals(3))
        {
            spot = 2;
            forTradeSelect.cardSlot = 1;
            popUpImage.sprite = playerCards.forTrade[1].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
    }

    public void forTrade3()
    {
        if (check.Equals(3))
        {
            if (playerCards.forTrade.Count > 1 && playerCards.forTrade.Count < 3)
            {
                forTradeSelect.cardSlot = 2;
                SceneManager.LoadScene("forTradeSelect");
            }
        }
        if (check.Equals(4))
        {
            spot = 3;
            forTradeSelect.cardSlot = 2;
            popUpImage.sprite = playerCards.forTrade[2].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
    }

    public void forTrade4()
    {
        if (check.Equals(4))
        {
            if (playerCards.forTrade.Count > 2 && playerCards.forTrade.Count < 4)
            {
                forTradeSelect.cardSlot = 3;
                SceneManager.LoadScene("forTradeSelect");
            }
        }
        if (check.Equals(5))
        {
            spot = 4;
            forTradeSelect.cardSlot = 3;
            popUpImage.sprite = playerCards.forTrade[3].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
        
    }

    public void forTrade5()
    {
        if (check.Equals(5))
        {
            if (playerCards.forTrade.Count > 3 && playerCards.forTrade.Count < 5)
            {
                forTradeSelect.cardSlot = 4;
                SceneManager.LoadScene("forTradeSelect");
            }
        }
        if (check.Equals(6))
        {
            spot = 5;
            forTradeSelect.cardSlot = 4;
            popUpImage.sprite = playerCards.forTrade[4].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
        
    }

    public void doCheck()
    {
        if (playerCards.forTrade.Count.Equals(0))
        {
            check = 1;
        }
        if (playerCards.forTrade.Count.Equals(1))
        {
            check = 2;
        }
        if (playerCards.forTrade.Count.Equals(2))
        {
            check = 3;
        }
        if (playerCards.forTrade.Count.Equals(3))
        {
            check = 4;
        }
        if (playerCards.forTrade.Count.Equals(4))
        {
            check = 5;
        }
        if (playerCards.forTrade.Count.Equals(5))
        {
            check = 6;
        }
    }

}
