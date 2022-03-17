using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cardManager : MonoBehaviour
{
    public static Card card1;
    public static int card1OriginalATK;
    public static int card1OrigonalDEF;
    public static int card1newATK;
    public static int card1newDEF;
    public static bool cardSelected;

    public static List<Card> sortedBinder = new List<Card>();
    public Image cardart1;
    public Text cardLevel;
    public Text credits;
    public Text CreditsPlus;
    public Text CreditsMinus;

    int startingCreditValue = player.credits;
    int newCreditValue;
    int startinglevelValue;
    int origLevelValue;

    int startingCardLevel;
    string cardName;

    void Start()
    {
        newCreditValue = startingCreditValue;

        if (cardSelect.card1Level != null)
        {
            startingCardLevel = int.Parse(cardSelect.card1Level);
            origLevelValue = int.Parse(cardSelect.card1Level);
        }

        sortedBinder = playerCards.userCards.OrderBy(x => x.rarity).ToList();
        sortedBinder.Reverse();

        player.credits = 9052;
        credits.text = "Credits: " + player.credits.ToString();

        //print(cardSelect.card1PosinList);
        if (cardSelected != false)
        {
            cardName = cardSelect.card1Name;
            startingCardLevel = int.Parse(cardSelect.card1Level);
            cardLevel.text = "Level: " + cardSelect.card1Level;
            cardart1.sprite = sortedBinder[cardSelect.card1PosinList].cardArt;
            credits.text = "Credits: " + player.credits.ToString();

            card1 = sortedBinder[cardSelect.card1PosinList];

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

    public void enhanceFinal()
    {
        if (cardSelected != false)
        {
            enhanceForm();
            SceneManager.LoadScene("enhanceFinal");
        }
    }

    public void enhanceUp()
    {
        int oneStarBaseMult = 764;
        int oneStarEvo1Mult = 1145;
        int oneStarEvo2Mult = 1526;
        int oneStarEvoMaxMult = 1908;
        int oneStarAwakenedMult = 3816;

        int twoStarBaseMult = 1017;
        int twoStarEvo1Mult = 1526;
        int twoStarEvo2Mult = 2035;
        int twoStarEvoMaxMult = 2543;
        int twoStarAwakenedMult = 5086;

        int threeStarBaseMult = 1385;
        int threeStarEvo1Mult = 2096;
        int threeStarEvo2Mult = 2795;
        int threeStarEvoMaxMult = 3494;
        int threeStarAwakenedMult = 6987;

        int fourStarBaseMult = 2133;
        int fourStarEvo1Mult = 3199;
        int fourStarEvo2Mult = 4265;
        int fourStarEvoMaxMult = 5332;
        int fourStarAwakenedMult = 10663;

        int fiveStarBaseMult = 3466;
        int fiveStarEvo1Mult = 5199;
        int fiveStarEvo2Mult = 6932;
        int fiveStarEvoMaxMult = 8665;
        int fiveStarAwakenedMult = 17331;

        if (cardSelected != false)
        {
            ///////////     1 Star    ///////////////
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
                if (startingCardLevel <= 19 && newCreditValue >= oneStarEvo1Mult && (cardName.Contains("evo1") || cardName.Contains("evo1+")))
                {
                    newCreditValue = newCreditValue - oneStarEvo1Mult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, oneStarEvo1Mult, "N"));
                }
                if (startingCardLevel <= 19 && newCreditValue >= oneStarEvo2Mult && (cardName.Contains("evo2") || cardName.Contains("evo2+")))
                {
                    newCreditValue = newCreditValue - oneStarEvo2Mult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, oneStarEvo2Mult, "N"));
                }
                if (startingCardLevel <= 19 && newCreditValue >= oneStarEvoMaxMult && (cardName.Contains("evomax") || cardName.Contains("evomax+")))
                {
                    newCreditValue = newCreditValue - oneStarEvoMaxMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, oneStarEvoMaxMult, "N"));
                }
                if (startingCardLevel <= 19 && newCreditValue >= oneStarAwakenedMult && (cardName.Contains("awakened") || cardName.Contains("awakened+")))
                {
                    newCreditValue = newCreditValue - oneStarAwakenedMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, oneStarAwakenedMult, "N"));
                }
            }

            ///////////     2 Star    ///////////////
            if (cardSelect.card1rarity.Equals(2))
            {
                if (startingCardLevel <= 29 && newCreditValue >= twoStarBaseMult && cardName.Contains("base"))
                {
                    newCreditValue = newCreditValue - twoStarBaseMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, twoStarBaseMult, "N"));
                }
                if (startingCardLevel <= 29 && newCreditValue >= twoStarEvo1Mult && (cardName.Contains("evo1") || cardName.Contains("evo1+")))
                {
                    newCreditValue = newCreditValue - twoStarEvo1Mult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, twoStarEvo1Mult, "N"));
                }
                if (startingCardLevel <= 29 && newCreditValue >= twoStarEvo2Mult && (cardName.Contains("evo2") || cardName.Contains("evo2+")))
                {
                    newCreditValue = newCreditValue - twoStarEvo2Mult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, twoStarEvo2Mult, "N"));
                }
                if (startingCardLevel <= 29 && newCreditValue >= twoStarEvoMaxMult && (cardName.Contains("evomax") || cardName.Contains("evomax+")))
                {
                    newCreditValue = newCreditValue - twoStarEvoMaxMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, twoStarEvoMaxMult, "N"));
                }
                if (startingCardLevel <= 29 && newCreditValue >= twoStarAwakenedMult && (cardName.Contains("awakened") || cardName.Contains("awakened+")))
                {
                    newCreditValue = newCreditValue - twoStarAwakenedMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, twoStarAwakenedMult, "N"));
                }
            }

            ///////////     3 Star    ///////////////
            if (cardSelect.card1rarity.Equals(3))
            {
                if (startingCardLevel <= 39 && newCreditValue >= threeStarBaseMult && cardName.Contains("base"))
                {
                    newCreditValue = newCreditValue - threeStarBaseMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, threeStarBaseMult, "N"));
                }
                if (startingCardLevel <= 39 && newCreditValue >= threeStarEvo1Mult && (cardName.Contains("evo1") || cardName.Contains("evo1+")))
                {
                    newCreditValue = newCreditValue - threeStarEvo1Mult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, threeStarEvo1Mult, "N"));
                }
                if (startingCardLevel <= 39 && newCreditValue >= threeStarEvo2Mult && (cardName.Contains("evo2") || cardName.Contains("evo2+")))
                {
                    newCreditValue = newCreditValue - threeStarEvo2Mult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, threeStarEvo2Mult, "N"));
                }
                if (startingCardLevel <= 39 && newCreditValue >= threeStarEvoMaxMult && (cardName.Contains("evomax") || cardName.Contains("evomax+")))
                {
                    newCreditValue = newCreditValue - threeStarEvoMaxMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, threeStarEvoMaxMult, "N"));
                }
                if (startingCardLevel <= 39 && newCreditValue >= threeStarAwakenedMult && (cardName.Contains("awakened") || cardName.Contains("awakened+")))
                {
                    newCreditValue = newCreditValue - threeStarAwakenedMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, threeStarAwakenedMult, "N"));
                }
            }

            ///////////     4 Star    ///////////////
            if (cardSelect.card1rarity.Equals(4))
            {
                if (startingCardLevel <= 49 && newCreditValue >= fourStarBaseMult && cardName.Contains("base"))
                {
                    newCreditValue = newCreditValue - fourStarBaseMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, fourStarBaseMult, "N"));
                }
                if (startingCardLevel <= 49 && newCreditValue >= fourStarEvo1Mult && (cardName.Contains("evo1") || cardName.Contains("evo1+")))
                {
                    newCreditValue = newCreditValue - fourStarEvo1Mult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, fourStarEvo1Mult, "N"));
                }
                if (startingCardLevel <= 49 && newCreditValue >= fourStarEvo2Mult && (cardName.Contains("evo2") || cardName.Contains("evo2+")))
                {
                    newCreditValue = newCreditValue - fourStarEvo2Mult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, fourStarEvo2Mult, "N"));
                }
                if (startingCardLevel <= 49 && newCreditValue >= fourStarEvoMaxMult && (cardName.Contains("evomax") || cardName.Contains("evomax+")))
                {
                    newCreditValue = newCreditValue - fourStarEvoMaxMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, fourStarEvoMaxMult, "N"));
                }
                if (startingCardLevel <= 49 && newCreditValue >= fourStarAwakenedMult && (cardName.Contains("awakened") || cardName.Contains("awakened+")))
                {
                    newCreditValue = newCreditValue - fourStarAwakenedMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, fourStarAwakenedMult, "N"));
                }
            }

            ///////////     5 Star    ///////////////
            if (cardSelect.card1rarity.Equals(5))
            {
                if (startingCardLevel <= 59 && newCreditValue >= fiveStarBaseMult && cardName.Contains("base"))
                {
                    newCreditValue = newCreditValue - fiveStarBaseMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, fiveStarBaseMult, "N"));
                }
                if (startingCardLevel <= 59 && newCreditValue >= fiveStarEvo1Mult && (cardName.Contains("evo1") || cardName.Contains("evo1+")))
                {
                    newCreditValue = newCreditValue - fiveStarEvo1Mult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, fiveStarEvo1Mult, "N"));
                }
                if (startingCardLevel <= 59 && newCreditValue >= fiveStarEvo2Mult && (cardName.Contains("evo2") || cardName.Contains("evo2+")))
                {
                    newCreditValue = newCreditValue - fiveStarEvo2Mult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, fiveStarEvo2Mult, "N"));
                }
                if (startingCardLevel <= 59 && newCreditValue >= fiveStarEvoMaxMult && (cardName.Contains("evomax") || cardName.Contains("evomax+")))
                {
                    newCreditValue = newCreditValue - fiveStarEvoMaxMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, fiveStarEvoMaxMult, "N"));
                }
                if (startingCardLevel <= 59 && newCreditValue >= fiveStarAwakenedMult && (cardName.Contains("awakened") || cardName.Contains("awakened+")))
                {
                    newCreditValue = newCreditValue - fiveStarAwakenedMult;
                    startingCardLevel += 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsMinus, 0.4f, fiveStarAwakenedMult, "N"));
                }
            }
        }
    }

    public void enhanceDown()
    {
        int oneStarBaseMult = 764;
        int oneStarEvo1Mult = 1145;
        int oneStarEvo2Mult = 1526;
        int oneStarEvoMaxMult = 1908;
        int oneStarAwakenedMult = 3816;

        int twoStarBaseMult = 1017;
        int twoStarEvo1Mult = 1526;
        int twoStarEvo2Mult = 2035;
        int twoStarEvoMaxMult = 2543;
        int twoStarAwakenedMult = 5086;

        int threeStarBaseMult = 1385;
        int threeStarEvo1Mult = 2096;
        int threeStarEvo2Mult = 2795;
        int threeStarEvoMaxMult = 3494;
        int threeStarAwakenedMult = 6987;

        int fourStarBaseMult = 2133;
        int fourStarEvo1Mult = 3199;
        int fourStarEvo2Mult = 4265;
        int fourStarEvoMaxMult = 5332;
        int fourStarAwakenedMult = 10663;

        int fiveStarBaseMult = 3466;
        int fiveStarEvo1Mult = 5199;
        int fiveStarEvo2Mult = 6932;
        int fiveStarEvoMaxMult = 8665;
        int fiveStarAwakenedMult = 17331;

        if (cardSelected != false)
        {
            ////////    1 Star      ////////
            if (cardSelect.card1rarity.Equals(1))
            {
                if (startingCardLevel > 1 && newCreditValue > 0 && cardName.Contains("base"))
                {
                    newCreditValue = newCreditValue + oneStarBaseMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, oneStarBaseMult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evo1") || cardName.Contains("evo1+")))
                {
                    newCreditValue = newCreditValue + oneStarEvo1Mult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, oneStarEvo1Mult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evo2") || cardName.Contains("evo2+")))
                {
                    newCreditValue = newCreditValue + oneStarEvo2Mult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, oneStarEvo2Mult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evomax") || cardName.Contains("evomax+")))
                {
                    newCreditValue = newCreditValue + oneStarEvoMaxMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, oneStarEvoMaxMult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("awakened") || cardName.Contains("awakened+")))
                {
                    newCreditValue = newCreditValue + oneStarAwakenedMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, oneStarAwakenedMult, "P"));
                }
            }

            ////////    2 Star      ////////
            if (cardSelect.card1rarity.Equals(2))
            {
                if (startingCardLevel > 1 && newCreditValue > 0 && cardName.Contains("base"))
                {
                    newCreditValue = newCreditValue + twoStarBaseMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, twoStarBaseMult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evo1") || cardName.Contains("evo1+")))
                {
                    newCreditValue = newCreditValue + twoStarEvo1Mult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, twoStarEvo1Mult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evo2") || cardName.Contains("evo2+")))
                {
                    newCreditValue = newCreditValue + twoStarEvo2Mult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, twoStarEvo2Mult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evomax") || cardName.Contains("evomax+")))
                {
                    newCreditValue = newCreditValue + twoStarEvoMaxMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, twoStarEvoMaxMult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("awakened") || cardName.Contains("awakened+")))
                {
                    newCreditValue = newCreditValue + twoStarAwakenedMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, twoStarAwakenedMult, "P"));
                }
            }

            ////////    3 Star      ////////
            if (cardSelect.card1rarity.Equals(3))
            {
                if (startingCardLevel > 1 && newCreditValue > 0 && cardName.Contains("base"))
                {
                    newCreditValue = newCreditValue + threeStarBaseMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, threeStarBaseMult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evo1") || cardName.Contains("evo1+")))
                {
                    newCreditValue = newCreditValue + threeStarEvo1Mult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, threeStarEvo1Mult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evo2") || cardName.Contains("evo2+")))
                {
                    newCreditValue = newCreditValue + threeStarEvo2Mult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, threeStarEvo2Mult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evomax") || cardName.Contains("evomax+")))
                {
                    newCreditValue = newCreditValue + threeStarEvoMaxMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, threeStarEvoMaxMult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("awakened") || cardName.Contains("awakened+")))
                {
                    newCreditValue = newCreditValue + threeStarAwakenedMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, threeStarAwakenedMult, "P"));
                }
            }

            ////////    4 Star      ////////
            if (cardSelect.card1rarity.Equals(4))
            {
                if (startingCardLevel > 1 && newCreditValue > 0 && cardName.Contains("base"))
                {
                    newCreditValue = newCreditValue + fourStarBaseMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, fourStarBaseMult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evo1") || cardName.Contains("evo1+")))
                {
                    newCreditValue = newCreditValue + fourStarEvo1Mult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, fourStarEvo1Mult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evo2") || cardName.Contains("evo2+")))
                {
                    newCreditValue = newCreditValue + fourStarEvo2Mult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, fourStarEvo2Mult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evomax") || cardName.Contains("evomax+")))
                {
                    newCreditValue = newCreditValue + fourStarEvoMaxMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, fourStarEvoMaxMult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("awakened") || cardName.Contains("awakened+")))
                {
                    newCreditValue = newCreditValue + fourStarAwakenedMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, fourStarAwakenedMult, "P"));
                }
            }

            ////////    5 Star      ////////
            if (cardSelect.card1rarity.Equals(5))
            {
                if (startingCardLevel > 1 && newCreditValue > 0 && cardName.Contains("base"))
                {
                    newCreditValue = newCreditValue + fiveStarBaseMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, fiveStarBaseMult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evo1") || cardName.Contains("evo1+")))
                {
                    newCreditValue = newCreditValue + fiveStarEvo1Mult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, fiveStarEvo1Mult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evo2") || cardName.Contains("evo2+")))
                {
                    newCreditValue = newCreditValue + fiveStarEvo2Mult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, fiveStarEvo2Mult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("evomax") || cardName.Contains("evomax+")))
                {
                    newCreditValue = newCreditValue + fiveStarEvoMaxMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, fiveStarEvoMaxMult, "P"));
                }
                if (startingCardLevel > 1 && newCreditValue > 0 && (cardName.Contains("awakened") || cardName.Contains("awakened+")))
                {
                    newCreditValue = newCreditValue + fiveStarAwakenedMult;
                    startingCardLevel -= 1;

                    cardLevel.text = "Level: " + startingCardLevel.ToString();
                    credits.text = "Credits: " + newCreditValue.ToString();
                    StartCoroutine(textAppear(CreditsPlus, 0.4f, fiveStarAwakenedMult, "P"));
                }
            }
        }
    }

    public void enhanceForm()
    {
        int numLevels;
        card1OriginalATK = card1.attack;
        card1OrigonalDEF = card1.defense;

        numLevels = startingCardLevel - origLevelValue;
        card1.attack = (int)(card1.attack_mult * numLevels) + card1OriginalATK;
        card1.defense = (int)(card1.defense_mult * numLevels) + card1OrigonalDEF;
        card1.level = origLevelValue + numLevels;
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
