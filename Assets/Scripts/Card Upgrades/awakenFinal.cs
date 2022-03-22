using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class awakenFinal : MonoBehaviour
{
    public Image card1Art;
    public Image card2Art;
    public Image finCard;
    public GameObject glow;
    public GameObject particles;
    public GameObject atkPanel;
    public GameObject defPanel;
    public GameObject button;
    public Text atk_Label;
    public Text def_Label;

    Card awakenCard;
    int highestATK;
    int highestDEF;
    double highestSkillLevel;
    int highestbaseskillLvl;

    public List<Card> awakened = new List<Card>();
    public List<Card> awakenedPlus = new List<Card>();

    // Start is called before the first frame update
    void Start()
    {
        if (awakenManagere.card1.attack == awakenManagere.card2.attack)
        {
            highestATK = awakenManagere.card1.attack;
        }
        if (awakenManagere.card1.attack > awakenManagere.card2.attack)
        {
            highestATK = awakenManagere.card1.attack;
        }
        else
        {
            highestATK = awakenManagere.card2.attack;
        }

        if (awakenManagere.card1.defense == awakenManagere.card2.defense)
        {
            highestDEF = awakenManagere.card1.defense;
        }
        if (awakenManagere.card1.defense > awakenManagere.card2.defense)
        {
            highestDEF = awakenManagere.card1.defense;
        }
        else
        {
            highestDEF = awakenManagere.card2.defense;
        }

        card1Art.sprite = awakenManagere.card1.cardArt;
        card2Art.sprite = awakenManagere.card2.cardArt;
        getAwakenedCard();
        getAwakenCardSkill(awakenManagere.card1, awakenManagere.card2);
        StartCoroutine(cardsMove(card1Art, card2Art, 1.5f));

        atk_Label.text = " ATK: " + highestATK.ToString() + " >> " + awakenCard.attack;
        def_Label.text = " DEF: " + highestDEF.ToString() + " >> " + awakenCard.defense;
        StartCoroutine(itemsAppear(atk_Label, def_Label, glow, atkPanel, defPanel, finCard, 3));
    }

    public void homeButton()
    {
        updatePlayerCards();
        subHolocrons(awakenCard.rarity, awakenCard.side);
        clearStuff();
        SceneManager.LoadScene("Home Screen");
    }

    void getAwakenedCard()
    {
        string cardname;
        cardname = awakenManagere.card1.cardName.Substring(0, awakenManagere.card1.cardName.IndexOf("_") + 6);

        if (awakenManagere.card1.cardName.Contains("evomax"))
        {
            for (int i = 0; i < awakened.Count; i++)
            {
                if (awakened[i].cardName.Contains(cardname))
                {
                    awakenCard = awakened[i];
                    finCard.sprite = awakenCard.cardArt;
                    break;
                }
            }
        }
    }

    void getAwakenCardSkill(Card card1, Card card2)
    {
        if (!card1.skill.Equals("None"))
        {
            if (card1.baseSkillLevel == card2.baseSkillLevel)
            {
                highestbaseskillLvl = card1.baseSkillLevel;
                highestSkillLevel = card1.skillLevel;
            }
            if (card1.baseSkillLevel > card2.baseSkillLevel)
            {
                highestbaseskillLvl = card1.baseSkillLevel;
                highestSkillLevel = card1.skillLevel;
            }
            else
            {
                highestbaseskillLvl = card2.baseSkillLevel;
                highestSkillLevel = card2.skillLevel;
            }
            awakenCard.skillLevel = highestSkillLevel;
            awakenCard.baseSkillLevel = highestbaseskillLvl;
        }
    }

    void updatePlayerCards()
    {
        playerCards.userCards.RemoveAt(awakenSelect1.origCard1Pos);
        playerCards.userCards.RemoveAt(awakenSelect2.origCard2Pos);
        playerCards.userCards.Add(awakenCard);
    }

    void subHolocrons(int rarity, char side)
    {
        if(rarity.Equals(1))
        {
            if(side.Equals('L'))
            {
                player.oneStarHoloLight -= 10;
                player.oneStarHoloNuet -= 5;
                player.twoStarHoloNuet -= 2;
            }
            if (side.Equals('D'))
            {
                player.oneStarHoloDark -= 10;
                player.oneStarHoloNuet -= 5;
                player.twoStarHoloNuet -= 2;
            }
            if (side.Equals('N'))
            {
                player.oneStarHoloLight -= 5;
                player.oneStarHoloDark -= 5;
                player.oneStarHoloNuet -= 5;
                player.twoStarHoloNuet -= 2;
            }
        }
        if (rarity.Equals(2))
        {
            if (side.Equals('L'))
            {
                player.oneStarHoloLight -= 12;
                player.twoStarHoloLight -= 4;
                player.twoStarHoloNuet -= 6;
                player.threeStarHoloNuet -= 3;
            }
            if (side.Equals('D'))
            {
                player.oneStarHoloDark -= 12;
                player.twoStarHoloDark -= 4;
                player.twoStarHoloNuet -= 6;
                player.threeStarHoloNuet -= 3;
            }
            if (side.Equals('N'))
            {
                player.twoStarHoloLight -= 8;
                player.twoStarHoloDark -= 8;
                player.twoStarHoloNuet -= 6;
                player.threeStarHoloNuet -= 3;
            }
        }
        if (rarity.Equals(3))
        {
            if (side.Equals('L'))
            {
                player.twoStarHoloLight -= 20;
                player.threeStarHoloLight -= 6;
                player.threeStarHoloNuet -= 10;
                player.fourStarHoloNuet -= 5;
            }
            if (side.Equals('D'))
            {
                player.twoStarHoloDark -= 20;
                player.threeStarHoloDark -= 6;
                player.threeStarHoloNuet -= 10;
                player.fourStarHoloNuet -= 5;
            }
            if (side.Equals('N'))
            {
                player.twoStarHoloLight -= 8;
                player.threeStarHoloLight -= 5;
                player.twoStarHoloDark -= 8;
                player.threeStarHoloDark -= 5;
                player.threeStarHoloNuet -= 10;
                player.fourStarHoloNuet -= 5;
            }
        }
        if (rarity.Equals(4))
        {
            if (side.Equals('L'))
            {
                player.threeStarHoloLight -= 12;
                player.fourStarHoloLight -= 6;
                player.threeStarHoloNuet -= 30;
                player.fourStarHoloNuet -= 10;
            }
            if (side.Equals('D'))
            {
                player.threeStarHoloDark -= 12;
                player.fourStarHoloDark -= 6;
                player.threeStarHoloNuet -= 30;
                player.fourStarHoloNuet -= 10;
            }
            if (side.Equals('N'))
            {
                player.threeStarHoloLight -= 6;
                player.fourStarHoloLight -= 3;
                player.threeStarHoloDark -= 6;
                player.fourStarHoloDark -= 3;
                player.threeStarHoloNuet -= 30;
                player.fourStarHoloNuet -= 10;
            }
        }
        if(rarity.Equals(5))
        {
            if (side.Equals('L'))
            {
                player.fourStarHoloLight -= 12;
                player.fiveStarHoloLight -= 6;
                player.fourStarHoloNuet -= 30;
                player.fiveStarHoloNuet -= 5;
            }
            if (side.Equals('D'))
            {
                player.fourStarHoloDark -= 12;
                player.fiveStarHoloDark -= 6;
                player.fourStarHoloNuet -= 30;
                player.fiveStarHoloNuet -= 5;
            }
            if (side.Equals('N'))
            {
                player.fourStarHoloLight -= 10;
                player.fiveStarHoloLight -= 4;
                player.fourStarHoloDark -= 10;
                player.fiveStarHoloDark -= 4;
                player.fourStarHoloNuet -= 20;
                player.fiveStarHoloNuet -= 3;
            }
        }
    }

    void clearStuff()
    {
        //Manager
        awakenManagere.card1 = null;
        awakenManagere.card2 = null;
        awakenManagere.card1Selected = false;
        awakenManagere.card2Selected = false;
        awakenManagere.sortedBinder.Clear();

        //Select
        awakenSelect1.card1PosinList = -1;
        awakenSelect1.origCard1Pos = -1;
        awakenSelect2.card2PosinList = -1;
        awakenSelect2.origCard2Pos = -1;

        //UI
        awaken1UI.cardOrigPos = -1;
        awaken2UI.cardOrigPos = -1;
    }

    IEnumerator itemsAppear(Text atk, Text def, GameObject glw, GameObject aPanel, GameObject dPanel, Image newCard, float delay)
    {
        button.SetActive(false);
        atk.transform.localScale = Vector2.zero;
        def.transform.localScale = Vector2.zero;
        glw.transform.localScale = Vector2.zero;
        aPanel.transform.localScale = Vector2.zero;
        dPanel.transform.localScale = Vector2.zero;
        newCard.transform.localScale = Vector2.zero;

        yield return new WaitForSeconds(delay);

        atk.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        def.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        glw.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        aPanel.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        dPanel.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        newCard.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        particles.SetActive(true);
        button.SetActive(true);
    }

    IEnumerator cardsMove(Image card1, Image card2, float delay)
    {
        yield return new WaitForSeconds(delay);
        card1.transform.LeanScale(Vector2.zero, 0.6f).setEaseOutQuart();
        card2.transform.LeanScale(Vector2.zero, 0.6f).setEaseOutQuart();
    }
}
