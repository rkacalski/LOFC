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

    int startingTremoteValue = player.training_remotes;
    double newTremoteValue;
    double origLevelValue;
    double newlevelValue;

    int baseLevel;

    double startingCardLevel;
    string cardName;

    void Start()
    {
        newTremoteValue = startingTremoteValue;

        player.training_remotes = 29;
        trainingRemotes.text = "Training Remotes: " + player.training_remotes.ToString();
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
            SceneManager.LoadScene("skillMastFinal");
        }
    }

    public void skillUp()
    {

        if (newTremoteValue <= 39)
        {
            newTremoteValue = newTremoteValue - 4; //add mult
            newlevelValue = newlevelValue + card1.skillLevMult;

            baseLevel += 1;

            cardLevel.text = "Level: " + baseLevel + "   (" + newlevelValue.ToString("f1") + ")";
            trainingRemotes.text = "Training Remotes: " + newTremoteValue.ToString();
        }
    }

    public void doSkillMath()
    {

    }
}