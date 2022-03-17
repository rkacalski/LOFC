using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class evoManager : MonoBehaviour
{
    public static Card card1;
    public static Card card2;
    public static bool cardSelected;

    public static List<Card> sortedBinder = new List<Card>();
    public Image cardart1;
    public Image cardart2;

    void Start()
    {
        if (cardSelected != false)
        {
            for (int i = 0; i < playerCards.userCards.Count; i++)
            {
                if ((!playerCards.userCards[i].cardName.Contains("evomax") || !playerCards.userCards[i].cardName.Contains("evomax+") || !playerCards.userCards[i].cardName.Contains("awakened") || !playerCards.userCards[i].cardName.Contains("awakened+")))
                {
                    sortedBinder.Add(playerCards.userCards[i]);
                }
            }

            sortedBinder = sortedBinder.OrderBy(x => x.rarity).ToList();
            sortedBinder.Reverse();

            card1 = sortedBinder[evo1Select.card1PosinList];
            cardart1.sprite = card1.cardArt;
        }
    }

    //Buttons
    public void skillMastSelectCard1()
    {
        SceneManager.LoadScene("evoSelect1");
    }

    public void skillMastSelectCard2()
    {
        SceneManager.LoadScene("evoSelect2");
    }
}
