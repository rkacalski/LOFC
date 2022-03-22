using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class evoFinal : MonoBehaviour
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

    public Card evoCard;
    int highestATK;
    int highestDEF;
    double highestSkillLevel;
    int highestbaseskillLvl;

    public List<Card> evo1 = new List<Card>();
    public List<Card> evo2 = new List<Card>();
    public List<Card> evo2plus = new List<Card>();
    public List<Card> evomax = new List<Card>();
    public List<Card> evomaxplus = new List<Card>();

    void Start()
    {
        //check for former Highest level;
        if(evoManager.card1.attack == evoManager.card2.attack)
        {
            highestATK = evoManager.card1.attack;
        }
        if(evoManager.card1.attack > evoManager.card2.attack)
        {
            highestATK = evoManager.card1.attack;
        }
        else
        {
            highestATK = evoManager.card2.attack;
        }

        if (evoManager.card1.defense == evoManager.card2.defense)
        {
            highestDEF = evoManager.card1.defense;
        }
        if (evoManager.card1.defense > evoManager.card2.defense)
        {
            highestDEF = evoManager.card1.defense;
        }
        else
        {
            highestDEF = evoManager.card2.defense;
        }

        card1Art.sprite = evoManager.card1.cardArt;
        card2Art.sprite = evoManager.card2.cardArt;
        getEvoCard();
        getEvoCardSkill(evoManager.card1, evoManager.card2);
        StartCoroutine(cardsMove(card1Art,card2Art,1.5f));

        atk_Label.text = " ATK: " + highestATK.ToString() + " >> " + evoCard.attack;
        def_Label.text = " DEF: " + highestDEF.ToString() + " >> " + evoCard.defense;
        StartCoroutine(itemsAppear(atk_Label, def_Label, glow, atkPanel, defPanel, finCard, 3));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void homeButton()
    {
        updatePlayerCards();
        clearStuff();
        SceneManager.LoadScene("Home Screen");
    }

    void updatePlayerCards()
    {
        playerCards.userCards.RemoveAt(evo1Select.origCard1Pos);
        playerCards.userCards.RemoveAt(evo2Select.origCard2Pos);
        playerCards.userCards.Add(evoCard);
    }

    void getEvoCard()
    {
        string cardname;
        cardname = evoManager.card1.cardName.Substring(0, evoManager.card1.cardName.IndexOf("_") + 6);


        if(evoManager.card1.cardName.Contains("base") && evoManager.card2.cardName.Contains("base"))
        {
            for(int i = 0; i < evo1.Count; i++)
            {
                if(evo1[i].cardName.Contains(cardname))
                {
                    evoCard = evo1[i];
                    finCard.sprite = evoCard.cardArt;
                    break;
                }
            }
        }
        if ((evoManager.card1.cardName.Contains("evo1") && evoManager.card2.cardName.Contains("base")) || (evoManager.card1.cardName.Contains("base") && evoManager.card2.cardName.Contains("evo1")))
        {
            //get card from evo2 list
        }
        if ((evoManager.card1.cardName.Contains("evo1") && evoManager.card2.cardName.Contains("evo1")))
        {
            //get card from evo2+ list
        }
        if ((evoManager.card1.cardName.Contains("evo2") && evoManager.card2.cardName.Contains("base")) || (evoManager.card1.cardName.Contains("base") && evoManager.card2.cardName.Contains("evo2")))
        {
            //get card from evomax list
        }
        if ((evoManager.card1.cardName.Contains("evo2+") && evoManager.card2.cardName.Contains("evo2+")))
        {
            //get card from evomax+ list
        }

        // Werid Evos
        if ((evoManager.card1.cardName.Contains("evo2+") && evoManager.card2.cardName.Contains("evo1")) || (evoManager.card1.cardName.Contains("evo1") && evoManager.card2.cardName.Contains("evo2+")))
        {
            //get card from evomax list
        }
        if ((evoManager.card1.cardName.Contains("evo2") && evoManager.card2.cardName.Contains("evo1")) || (evoManager.card1.cardName.Contains("evo1") && evoManager.card2.cardName.Contains("evo2")))
        {
            //get card from evomax list
        }
        if ((evoManager.card1.cardName.Contains("evo2+") && evoManager.card2.cardName.Contains("base")) || (evoManager.card1.cardName.Contains("base") && evoManager.card2.cardName.Contains("evo2+")))
        {
            //get card from evomax list
        }
        // Werid Evos
        if ((evoManager.card1.cardName.Contains("evo2+") && evoManager.card2.cardName.Contains("evo2")) || (evoManager.card1.cardName.Contains("evo2") && evoManager.card2.cardName.Contains("evo2+")))
        {
            //get card from evomax list
        }

    }

    void getEvoCardSkill(Card card1, Card card2)
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
            evoCard.skillLevel = highestSkillLevel;
            evoCard.baseSkillLevel = highestbaseskillLvl;
        }
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

    void clearStuff()
    {
        //Manager
        evoManager.card1 = null;
        evoManager.card2 = null;
        evoManager.card1Selected = false;
        evoManager.card2Selected = false;
        evoManager.sortedBinder.Clear();

        //Select
        evo1Select.card1PosinList = -1;
        evo1Select.origCard1Pos = -1;
        evo2Select.card2PosinList = -1;
        evo2Select.origCard2Pos = -1;

        //UI
        evo1UI.cardOrigPos = -1;
        evo2UI.cardOrigPos = -1;
    }
}
