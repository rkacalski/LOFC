using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wishlistbuttons : MonoBehaviour
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
        playerCards.wishlist.RemoveAt(wishlistSelect.cardSlot);
        if (spot.Equals(1))
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
            if (playerCards.wishlist.Count < 1)
            {
                wishlistSelect.cardSlot = 0;
                SceneManager.LoadScene("wishlistSelect");
            }
        }
        if (check.Equals(2))
        {
            spot = 1;
            wishlistSelect.cardSlot = 0;
            popUpImage.sprite = playerCards.wishlist[0].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
    }

    public void forTrade2()
    {
        if (check.Equals(2))
        {
            if (playerCards.wishlist.Count > 0 && playerCards.wishlist.Count < 2)
            {
                wishlistSelect.cardSlot = 1;
                SceneManager.LoadScene("wishlistSelect");
            }
        }
        if (check.Equals(3))
        {
            spot = 2;
            wishlistSelect.cardSlot = 1;
            popUpImage.sprite = playerCards.wishlist[1].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
    }

    public void forTrade3()
    {
        if (check.Equals(3))
        {
            if (playerCards.wishlist.Count > 1 && playerCards.wishlist.Count < 3)
            {
                wishlistSelect.cardSlot = 2;
                SceneManager.LoadScene("wishlistSelect");
            }
        }
        if (check.Equals(4))
        {
            spot = 3;
            wishlistSelect.cardSlot = 2;
            popUpImage.sprite = playerCards.wishlist[2].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
    }

    public void forTrade4()
    {
        if (check.Equals(4))
        {
            if (playerCards.wishlist.Count > 2 && playerCards.wishlist.Count < 4)
            {
                wishlistSelect.cardSlot = 3;
                SceneManager.LoadScene("wishlistSelect");
            }
        }
        if (check.Equals(5))
        {
            spot = 4;
            wishlistSelect.cardSlot = 3;
            popUpImage.sprite = playerCards.wishlist[3].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }

    }

    public void forTrade5()
    {
        if (check.Equals(5))
        {
            if (playerCards.wishlist.Count > 3 && playerCards.wishlist.Count < 5)
            {
                wishlistSelect.cardSlot = 4;
                SceneManager.LoadScene("wishlistSelect");
            }
        }
        if (check.Equals(6))
        {
            spot = 5;
            wishlistSelect.cardSlot = 4;
            popUpImage.sprite = playerCards.wishlist[4].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }

    }

    public void doCheck()
    {
        if (playerCards.wishlist.Count.Equals(0))
        {
            check = 1;
        }
        if (playerCards.wishlist.Count.Equals(1))
        {
            check = 2;
        }
        if (playerCards.wishlist.Count.Equals(2))
        {
            check = 3;
        }
        if (playerCards.wishlist.Count.Equals(3))
        {
            check = 4;
        }
        if (playerCards.wishlist.Count.Equals(4))
        {
            check = 5;
        }
        if (playerCards.wishlist.Count.Equals(5))
        {
            check = 6;
        }
    }

}
