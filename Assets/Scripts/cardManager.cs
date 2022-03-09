using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cardManager : MonoBehaviour
{
    public static Card card1;
    public static bool cardSelected;

    List<Card> sortedBinder = new List<Card>();
    public Image cardart1;
    public Text cardLevel;
    public Text credits;
    public Text CreditsPlus;
    public Text CreditsMinus;

    int startingCreditValue = player.credits;
    int newCreditValue;
    int startinglevelValue;

    int startingCardLevel;
    string cardName;

    void Start()
    {
        newCreditValue = startingCreditValue;
        startingCardLevel = 1;

        sortedBinder = playerCards.userCards.OrderBy(x => x.rarity).ToList();
        sortedBinder.Reverse();

        player.credits = 1650;
        credits.text = "Credits: " + player.credits.ToString();

        print(cardSelect.card1PosinList);
        if (cardSelected != false)
        {
            cardName = cardSelect.card1Name;
            startingCardLevel = int.Parse(cardSelect.card1Level);
            cardLevel.text = "Level: " + cardSelect.card1Level;
            cardart1.sprite = sortedBinder[cardSelect.card1PosinList].cardArt;
            credits.text = "Credits: " + player.credits.ToString();
        }
        
    }

    void Update()
    {

    }

    //Buttons
    public void enhanceSelect()
    {
        SceneManager.LoadScene("enhanceCardSelect");
    }

    public void enhanceUp()
    {
        int oneStarBaseMult = 764;
        int oneStarEvo1Mult = 1145;
        //int oneStarEvo2Mult = 1526;
        //int oneStarEvoMaxMult = 1908;
        //int oneStarAwakenedMult = 3816;

        if (cardSelected != false)
        {
            if (cardSelect.card1rarity.Equals(1))
            {
                if (startingCardLevel <= 19 && newCreditValue >= oneStarBaseMult && cardName.Contains("base")) 
                {
                    newCreditValue = newCreditValue - oneStarBaseMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, oneStarBaseMult, "N"));
                }
                if (startingCardLevel <= 19 && newCreditValue >= oneStarEvo1Mult && cardName.Contains("evo1") || cardName.Contains("evo1+"))
                {
                    newCreditValue = newCreditValue - oneStarEvo1Mult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, oneStarEvo1Mult, "N"));
                }
            }
        }
    }

    public void enhanceDown()
    {
        int oneStarBaseMult = 764;
        int oneStarEvo1Mult = 1145;
        //int oneStarEvo2Mult = 1526;
        //int oneStarEvoMaxMult = 1908;
        //int oneStarAwakenedMult = 3816;

        if (cardSelected != false)
        {
            if (startingCardLevel > 1 && newCreditValue > 0 && cardName.Contains("base")) 
            {
                newCreditValue = newCreditValue + oneStarBaseMult;
                startingCardLevel -= 1;

                cardLevel.text = "Level: " + startingCardLevel.ToString();
                credits.text = "Credits: " + newCreditValue.ToString();
                StartCoroutine(textAppear(CreditsPlus, 0.4f, oneStarBaseMult, "P"));
            }
            if (startingCardLevel > 1 && newCreditValue > 0 && cardName.Contains("evo1"))
            {
                newCreditValue = newCreditValue + oneStarEvo1Mult;
                startingCardLevel -= 1;

                cardLevel.text = "Level: " + startingCardLevel.ToString();
                credits.text = "Credits: " + newCreditValue.ToString();
                StartCoroutine(textAppear(CreditsPlus, 0.4f, oneStarEvo1Mult, "P"));
            }
        }
    }

    IEnumerator textAppear(Text go, float delay, int amnt, string PorN)
    {
        if (PorN.Equals("P"))
        {
            go.text = "+" + amnt.ToString();
        }
        else
        {
            go.text = "-" + amnt.ToString();
        }
        go.gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.gameObject.SetActive(false);
    }
}
