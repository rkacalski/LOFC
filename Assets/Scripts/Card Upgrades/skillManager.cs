using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skillManager : MonoBehaviour
{
    public static Card card1;
    public static int card1Originalskill;
    public static int card1newskill;
    public static bool cardSelected;

    public static List<Card> sortedBinder = new List<Card>();
    public Image cardart1;
    public Text cardLevel;
    public Text trainingRemotes;
    public Text TremotePlus;
    public Text TrenoteMinus;

    int startingTremoteValue;
    int newTremoteValue;
    double origLevelValue;
    double newlevelValue;

    int baseLevel;

    public static double startingCardLevel;
    public static int startingLvlValue;
    string cardName;

    void Start()
    {
        //newTremoteValue = startingTremoteValue;

        player.training_remotes = 40;
        trainingRemotes.text = "Training Remotes: " + player.training_remotes.ToString();

        startingTremoteValue = player.training_remotes;
        newTremoteValue = startingTremoteValue;

        cardLevel.text = "Level: ";

        //print(cardSelect.card1PosinList);
        if (cardSelected != false)
        {
            for (int i = 0; i < playerCards.userCards.Count; i++)
            {
                if (!playerCards.userCards[i].skill.Equals("None"))
                {
                    sortedBinder.Add(playerCards.userCards[i]);
                }
            }

            sortedBinder = sortedBinder.OrderBy(x => x.rarity).ToList();
            sortedBinder.Reverse();

            card1 = sortedBinder[skillMastSelect.cardPosinList];

            newlevelValue = card1.skillLevel;
            baseLevel = card1.baseSkillLevel;

            cardName = card1.displayName;
            startingCardLevel = card1.skillLevel;
            startingLvlValue = card1.baseSkillLevel;
            cardLevel.text = "Level: " + card1.baseSkillLevel.ToString() + "   (" + card1.skillLevel + ")";
            cardart1.sprite = card1.cardArt;
            trainingRemotes.text = "Training Remotes: " + player.training_remotes.ToString();
        }
    }

    //Buttons
    public void skillMastSelectCard()
    {
        SceneManager.LoadScene("skillMastSelect");
    }

    public void skillMastFinal()
    {
        if (cardSelected != false)
        {
            doSkillMath();
            SceneManager.LoadScene("skillMastFinal");
        }
    }

    public void skillUp()
    {
        int tRemoteMult;
        tRemoteMult = tremoteMult(baseLevel);

        if (cardSelected != false)
        {
            if ((card1.cardName.Contains("base") || card1.cardName.Contains("base+")) && baseLevel <= 9 && newTremoteValue >= tRemoteMult)
            {
                newTremoteValue = newTremoteValue - tRemoteMult;
                newlevelValue = newlevelValue + card1.skillLevMult;

                baseLevel += 1;

                cardLevel.text = "Level: " + baseLevel + "   (" + newlevelValue.ToString("f1") + ")";
                trainingRemotes.text = "Training Remotes: " + newTremoteValue.ToString();

                StartCoroutine(textAppear(TrenoteMinus, 0.4f, tRemoteMult, "N"));
            }
            if ((card1.cardName.Contains("evo1") || card1.cardName.Contains("evo1+")) && baseLevel <= 19 && newTremoteValue >= tRemoteMult)
            {
                newTremoteValue = newTremoteValue - tRemoteMult;
                newlevelValue = newlevelValue + card1.skillLevMult;

                baseLevel += 1;

                cardLevel.text = "Level: " + baseLevel + "   (" + newlevelValue.ToString("f1") + ")";
                trainingRemotes.text = "Training Remotes: " + newTremoteValue.ToString();

                StartCoroutine(textAppear(TrenoteMinus, 0.4f, tRemoteMult, "N"));
            }
            if ((card1.cardName.Contains("evo2") || card1.cardName.Contains("evo2+")) && baseLevel <= 29 && newTremoteValue >= tRemoteMult)
            {
                newTremoteValue = newTremoteValue - tRemoteMult;
                newlevelValue = newlevelValue + card1.skillLevMult;

                baseLevel += 1;

                cardLevel.text = "Level: " + baseLevel + "   (" + newlevelValue.ToString("f1") + ")";
                trainingRemotes.text = "Training Remotes: " + newTremoteValue.ToString();

                StartCoroutine(textAppear(TrenoteMinus, 0.4f, tRemoteMult, "N"));
            }
            if ((card1.cardName.Contains("evomax") || card1.cardName.Contains("evomax+")) && baseLevel <= 39 && newTremoteValue >= tRemoteMult)
            {
                newTremoteValue = newTremoteValue - tRemoteMult;
                newlevelValue = newlevelValue + card1.skillLevMult;

                baseLevel += 1;

                cardLevel.text = "Level: " + baseLevel + "   (" + newlevelValue.ToString("f1") + ")";
                trainingRemotes.text = "Training Remotes: " + newTremoteValue.ToString();

                StartCoroutine(textAppear(TrenoteMinus, 0.4f, tRemoteMult, "N"));
            }
            if ((card1.cardName.Contains("awakened") || card1.cardName.Contains("awakened+")) && baseLevel <= 49 && newTremoteValue >= tRemoteMult)
            {
                newTremoteValue = newTremoteValue - tRemoteMult;
                newlevelValue = newlevelValue + card1.skillLevMult;

                baseLevel += 1;

                cardLevel.text = "Level: " + baseLevel + "   (" + newlevelValue.ToString("f1") + ")";
                trainingRemotes.text = "Training Remotes: " + newTremoteValue.ToString();

                StartCoroutine(textAppear(TrenoteMinus, 0.4f, tRemoteMult, "N"));
            }
        }
    }

    public void skillDown()
    {
        int tRemoteMult;

        if (baseLevel > 3)
        {
            tRemoteMult = tremoteMult(baseLevel-1);
        }
        else
        {
            tRemoteMult = tremoteMult(baseLevel);
        }

        if (cardSelected != false)
        {
            if (baseLevel > 1 && newTremoteValue > 0)
            {
                newTremoteValue = newTremoteValue + tRemoteMult;
                newlevelValue = newlevelValue - card1.skillLevMult;

                baseLevel -= 1;

                cardLevel.text = "Level: " + baseLevel + "   (" + newlevelValue.ToString("f1") + ")";
                trainingRemotes.text = "Training Remotes: " + newTremoteValue.ToString();

                StartCoroutine(textAppear(TremotePlus, 0.4f, tRemoteMult, "P"));
            }
        }
    }

    public int tremoteMult(int currentLevel)
    {
        if(1 <= currentLevel && currentLevel <= 3)
        {
            return 1;
        }
        if (4 <= currentLevel && currentLevel <= 5)
        {
            return 2;
        }
        if (6 <= currentLevel && currentLevel <= 9)
        {
            return 4;
        }
        if (10 <= currentLevel && currentLevel <= 14)
        {
            return 6;
        }
        if (15 <= currentLevel && currentLevel <= 20)
        {
            return 8;
        }
        if (21 <= currentLevel && currentLevel <= 25)
        {
            return 10;
        }
        if (26 <= currentLevel && currentLevel <= 30)
        {
            return 12;
        }
        if (26 <= currentLevel && currentLevel <= 30)
        {
            return 12;
        }
        if (31 <= currentLevel && currentLevel <= 34)
        {
            return 15;
        }
        if (35 <= currentLevel && currentLevel <= 39)
        {
            return 20;
        }
        if (currentLevel == 40)
        {
            return 30;
        }
        if (41 <= currentLevel && currentLevel <= 45)
        {
            return 34;
        }
        if (46 <= currentLevel && currentLevel <= 49)
        {
            return 38;
        }
        if (currentLevel == 50)
        {
            return 40;
        }
        return 0;
    }

    public void doSkillMath()
    {
        int numLevels;
        numLevels = baseLevel - card1.baseSkillLevel;
        card1.skillLevel = (card1.skillLevMult * numLevels) + card1.skillLevel;
        card1.baseSkillLevel = baseLevel;
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