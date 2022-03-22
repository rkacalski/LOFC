using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class awakenManagere : MonoBehaviour
{
    public static Card card1;
    public static Card card2;
    public static bool card1Selected;
    public static bool card2Selected;

    public GameObject notenough;

    List<Card> tempBinder = new List<Card>();
    public static List<Card> sortedBinder = new List<Card>();
    public Image cardart1;
    public Image cardart2;

    // Start is called before the first frame update
    void Start()
    {
        notenough.transform.localScale = Vector2.zero;

        player.oneStarHoloLight = 10;
        player.oneStarHoloDark = 5;
        player.oneStarHoloNuet = 5;
        player.twoStarHoloNuet = 2;


        for (int i = 0; i < playerCards.userCards.Count; i++)
        {
            if (playerCards.userCards[i].cardName.Contains("evomax") || playerCards.userCards[i].cardName.Contains("evomax+"))
            {
                if (playerCards.userCards[i].rarity.Equals(1) && (playerCards.userCards[i].level.Equals(20)))
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
            card1 = sortedBinder[awakenSelect1.card1PosinList];
            cardart1.sprite = card1.cardArt;
        }
        if (card2Selected != false)
        {
            card2 = sortedBinder[awakenSelect2.card2PosinList];
            cardart2.sprite = card2.cardArt;
        }
    }

    //buttons
    public void awakenSelectCard1()
    {
        SceneManager.LoadScene("awakenSelect1");
    }

    public void awakenSelectCard2()
    {
        if (card1Selected != false)
        {
            SceneManager.LoadScene("awakenSelect2");
        }
    }

    public void awakenCardFinal()
    {
        if ((card1Selected == true) && (card2Selected == true))
        {
            if (holoCheck(card1.rarity, card1.side) == true)
            {
                SceneManager.LoadScene("awakenFinal");
            }
            else
            {
                StartCoroutine(textAppear(notenough, 3f));
            }
        }
    }

    //Check if enough holocrons exsist to do awakening
    public bool holoCheck(int rarity, char side)
    {
        //1 Star
        if(rarity.Equals(1))
        {
            if (side.Equals('L'))
            {
                if ((player.oneStarHoloLight >= 10) && (player.oneStarHoloNuet >= 5) && (player.twoStarHoloNuet >= 2))
                {
                    return true;
                }
            }
            if (side.Equals('D'))
            {
                if ((player.oneStarHoloDark >= 10) && (player.oneStarHoloNuet >= 5) && (player.twoStarHoloNuet >= 2))
                {
                    return true;
                }
            }
            if (side.Equals('N'))
            {
                if ((player.oneStarHoloLight >= 5) && (player.oneStarHoloDark >= 5) && (player.oneStarHoloNuet >= 5) && (player.twoStarHoloNuet >= 2))
                {
                    return true;
                }
            }
        }

        //2 Star
        if (rarity.Equals(2))
        {
            if (side.Equals('L'))
            {
                if ((player.oneStarHoloLight >= 12) && (player.twoStarHoloLight >= 4) && (player.twoStarHoloNuet >= 6) && (player.threeStarHoloNuet >= 3))
                {
                    return true;
                }
            }
            if (side.Equals('D'))
            {
                if ((player.oneStarHoloDark >= 12) && (player.twoStarHoloDark >= 4) && (player.twoStarHoloNuet >= 6) && (player.threeStarHoloNuet >= 3))
                {
                    return true;
                }
            }
            if (side.Equals('N'))
            {
                if ((player.twoStarHoloLight >= 8) && (player.twoStarHoloDark >= 8) && (player.twoStarHoloNuet >= 6) && (player.threeStarHoloNuet >= 3))
                {
                    return true;
                }
            }
        }

        //3 Star
        if (rarity.Equals(3))
        {
            if (side.Equals('L'))
            {
                if ((player.twoStarHoloLight >= 20) && (player.threeStarHoloLight >= 6) && (player.threeStarHoloNuet >= 10) && (player.fourStarHoloNuet >= 5))
                {
                    return true;
                }
            }
            if (side.Equals('D'))
            {
                if ((player.twoStarHoloDark >= 20) && (player.threeStarHoloDark >= 6) && (player.threeStarHoloNuet >= 10) && (player.fourStarHoloNuet >= 5))
                {
                    return true;
                }
            }
            if (side.Equals('N'))
            {
                if ((player.twoStarHoloLight >= 8) && (player.threeStarHoloLight >= 5) && (player.twoStarHoloDark >= 8) && (player.threeStarHoloDark >= 5) && (player.threeStarHoloNuet >= 10) && (player.fourStarHoloNuet >= 5))
                {
                    return true;
                }
            }
        }

        //4 Star
        if (rarity.Equals(4))
        {
            if (side.Equals('L'))
            {
                if ((player.threeStarHoloLight >= 12) && (player.fourStarHoloLight >= 6) && (player.threeStarHoloNuet >= 30) && (player.fourStarHoloNuet >= 10))
                {
                    return true;
                }
            }
            if (side.Equals('D'))
            {
                if ((player.threeStarHoloDark >= 12) && (player.fourStarHoloDark >= 6) && (player.threeStarHoloNuet >= 30) && (player.fourStarHoloNuet >= 10))
                {
                    return true;
                }
            }
            if (side.Equals('N'))
            {
                if ((player.threeStarHoloLight >= 6) && (player.fourStarHoloLight >= 3) && (player.threeStarHoloDark >= 6) && (player.fourStarHoloDark >= 3) && (player.threeStarHoloNuet >= 30) && (player.fourStarHoloNuet >= 10))
                {
                    return true;
                }
            }
        }

        //5 Star
        if (rarity.Equals(5))
        {
            if (side.Equals('L'))
            {
                if ((player.fourStarHoloLight >= 12) && (player.fiveStarHoloLight >= 6) && (player.fourStarHoloNuet >= 30) && (player.fiveStarHoloNuet >= 5))
                {
                    return true;
                }
            }
            if (side.Equals('D'))
            {
                if ((player.fourStarHoloDark >= 12) && (player.fiveStarHoloDark >= 6) && (player.fourStarHoloNuet >= 30) && (player.fiveStarHoloNuet >= 5))
                {
                    return true;
                }
            }
            if (side.Equals('N'))
            {
                if ((player.fourStarHoloLight >= 10) && (player.fiveStarHoloLight >= 4) && (player.fourStarHoloDark >= 10) && (player.fiveStarHoloDark >= 4) && (player.fourStarHoloNuet >= 20) && (player.fiveStarHoloNuet >= 3))
                {
                    return true;
                }
            }
        }

        return false;
    }

    IEnumerator textAppear(GameObject go, float delay)
    {
        go.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        yield return new WaitForSeconds(delay);
        go.transform.LeanScale(Vector2.zero, 0.6f).setEaseOutQuart();
    }
}
