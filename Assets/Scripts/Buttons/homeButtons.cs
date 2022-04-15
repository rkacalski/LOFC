using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class homeButtons : MonoBehaviour
{
    public GameObject operationPopup;
    public GameObject cardPopup;
    public GameObject allyPopup;
    public int popup;

    private void Start()
    {
        operationPopup.transform.localScale = Vector2.zero;
        cardPopup.transform.localScale = Vector2.zero;
        allyPopup.transform.localScale = Vector2.zero;
        popup = 0;
    }

    //Main Buttons (Inbox, Goals, Packs, Operations card ally popups, chat, exit button)


    public void operationOpen()
    {
        operationPopup.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        popup = 1;
    }

    public void allyOpen()
    {
        allyPopup.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        popup = 2;
    }

    public void cardOpen()
    {
        cardPopup.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        popup = 3;
    }

    public void popupClose()
    {
        if(popup.Equals(1))
        {
            operationPopup.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
        }
        if (popup.Equals(2))
        {
            allyPopup.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
        }
        if (popup.Equals(3))
        {
            cardPopup.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
        }
    }

    // Quest, Battle, Rankings

    public void questButton()
    {
        SceneManager.LoadScene("QuestHome");
    }

    public void battleButton()
    {
        SceneManager.LoadScene("endor_6.6_N");
    }

    //Card pop up (packs, form, card binder, hanger, enhance)

    public void formationButton()
    {
        SceneManager.LoadScene("Formation Screen");
    }

    public void cardbinderButton()
    {
        SceneManager.LoadScene("Card Binder");
    }

    public void hangerButton()
    {
        SceneManager.LoadScene("Hanger");
    }

    public void enhanceButton()
    {
        SceneManager.LoadScene("enhanceCardMain");
    }

    //Allies pop up (message, trade, wishlist, allies)

    public void wishlistButton()
    {
        SceneManager.LoadScene("tradeBlock");
    }

    //Operations popup
    public void evolve()
    {
        SceneManager.LoadScene("evoHome");
    }

    public void skillMast()
    {
        SceneManager.LoadScene("skillMastMain");
    }

    //blue prints, Card archive

}
