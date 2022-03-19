using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class evoManager : MonoBehaviour
{
    public GameObject pop47;
    public GameObject pop815;

    public static Card card1;
    public static Card card2;
    public static bool card1Selected;
    public static bool card2Selected;

    List<Card> tempBinder = new List<Card>();
    public static List<Card> sortedBinder = new List<Card>();
    public Image cardart1;
    public Image cardart2;

    void Start()
    {
        pop47.transform.localScale = Vector2.zero;
        pop815.transform.localScale = Vector2.zero;

        //for final delete the not from 1 and 5 star
        for (int i = 0; i < playerCards.userCards.Count; i++)
        {
            if ((!playerCards.userCards[i].cardName.Contains("evomax")) && (!playerCards.userCards[i].cardName.Contains("evomax+")) && (!playerCards.userCards[i].cardName.Contains("awakened")) && (!playerCards.userCards[i].cardName.Contains("awakened+")))
            {
                if (playerCards.userCards[i].rarity.Equals(1) && (!playerCards.userCards[i].level.Equals(20)))
                {
                    tempBinder.Add(playerCards.userCards[i]);
                }
                if (playerCards.userCards[i].rarity.Equals(2) && (playerCards.userCards[i].level.Equals(30)))
                {
                    tempBinder.Add(playerCards.userCards[i]);
                }
                if (playerCards.userCards[i].rarity.Equals(3) && (playerCards.userCards[i].level.Equals(40)))
                {
                    tempBinder.Add(playerCards.userCards[i]);
                }
                if (playerCards.userCards[i].rarity.Equals(4) && (playerCards.userCards[i].level.Equals(50)))
                {
                    tempBinder.Add(playerCards.userCards[i]);
                }
                if (playerCards.userCards[i].rarity.Equals(5) && (!playerCards.userCards[i].level.Equals(60)))
                {
                    tempBinder.Add(playerCards.userCards[i]);
                }
            }
        }

        sortedBinder = tempBinder.OrderBy(x => x.rarity).ToList();
        sortedBinder.Reverse();

        tempBinder.Clear();

        if (card1Selected != false)
        {
            card1 = sortedBinder[evo1Select.card1PosinList];
            cardart1.sprite = card1.cardArt;
        }
        if (card2Selected != false)
        {
            card2 = sortedBinder[evo2Select.card2PosinList];
            cardart2.sprite = card2.cardArt;
        }
    }

    //Buttons
    public void skillMastSelectCard1()
    {
        SceneManager.LoadScene("evoSelect1");
    }

    public void skillMastSelectCard2()
    {
        if (card1Selected != false)
        {
            SceneManager.LoadScene("evoSelect2");
        }
    }

    public void evoFinal()
    {
        if((card1Selected == true) && (card2Selected == true))
        {
            SceneManager.LoadScene("evoFinal");
        }
    }

    public void select47()
    {
        pop47.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void select815()
    {
        pop815.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popupClose()
    {
        pop47.transform.localScale = Vector2.zero;
        pop815.transform.localScale = Vector2.zero;
    }
}
